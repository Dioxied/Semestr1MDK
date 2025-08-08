import json, time, requests, io, base64
import tkinter as tk
from tkinter import ttk
from tkinter import messagebox
from PIL import Image, ImageTk

API_KEY = "A3C26D630C9BA1F3B90FC4F889B2F5F9"
SECRET_KEY = "913DC97207FEC34A44AF7600F70B7BC2"
API_URL = "https://api-key.fusionbrain.ai/"

class FusionBrainAPI:
    def __init__(self, url, api_key, secret_key):
        self.URL = url
        self.AUTH_HEADERS = {
            'X-Key': f'Key {api_key}',
            'X-Secret': f'Secret {secret_key}'
        }
    
    def get_pipeline(self):
        response = requests.get(self.URL + 'key/api/v1/pipelines', headers=self.AUTH_HEADERS)
        data = response.json()
        return data[0]['id']
    
    def generate(self, prompt, pipeline_id, width=1024, height=1024):
        params = {
            "type": "GENERATE",
            "numImages": 1,
            "width": width,
            "height": height,
            "generateParams": {
                "query": prompt
            }
        }
        data = {
            "pipeline_id": (None, pipeline_id),
            "params": (None, json.dumps(params), "application/json")
        }
        response = requests.post(self.URL + "key/api/v1/pipeline/run",
            headers=self.AUTH_HEADERS, files=data)
        return response.json()['uuid']
    
    def check_generation(self, uuid, attempts=10, delay=5):
        while attempts > 0:
            response = requests.get(self.URL + f'key/api/v1/pipeline/status/{uuid}', headers=self.AUTH_HEADERS)
            data = response.json()
            if data['status'] == 'DONE':
                return data['result']['files'][0]
            
            elif data['status'] == 'FAIL':
                raise Exception("Ошибка генерации изоюражения.")
            
            attempts -= 1
            time.sleep(delay)
        raise TimeoutError("Время ожидания генерации истекло")
        
class App:
    def __init__(self, root):
        self.root = root
        self.root.title("Генератор изображения Kandinsky")
        self.api = FusionBrainAPI(API_URL, API_KEY, SECRET_KEY)
        self.pipeline_id = self.api.get_pipeline()

        self.prompt_label = tk.Label(root, text="Введите описание изображения.")
        self.prompt_label.pack()

        self.prompt_entry = tk.Entry(root, width=60)
        self.prompt_entry.pack(pady=5)

        self.generate_button = ttk.Button(root, text="Сгенерировать", command=self.generate_image)
        self.generate_button.pack(pady=10)

        self.image_label = tk.Label(root)
        self.image_label.pack()

    def generate_image(self):
        prompt = self.prompt_entry.get()
        if not prompt:
            messagebox.showwarning("Ошибка", "Пожалуйста, введите описание (промпт).")
            return
        try:
            self.generate_button.config(state="disabled")
            uuid = self.api.generate(prompt, self.pipeline_id)
            base64_image = self.api.check_generation(uuid)
            image_data = base64.b64decode(base64_image)
            image = Image.open(io.BytesIO(image_data))
            image = ImageTk.PhotoImage(image)
            self.image_label.config(image=image)
            self.image_label.image = image

        except Exception as e:
            messagebox.showerror("Ошибка", f"Произошла шибка при генерации изображения: {str(e)}")

        finally:
            self.generate_button.config(state="normal")

if __name__ == "__main__":
    root = tk.Tk()
    app = App(root)
    root.mainloop()