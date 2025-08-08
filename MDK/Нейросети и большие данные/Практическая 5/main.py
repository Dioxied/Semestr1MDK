import json, time, requests, io, base64
from PIL import Image
from PyQt5 import uic
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *
import sys


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

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        uic.loadUi("uuu.ui", self)
        self.setWindowTitle("Создай свою аватарку")

        self.line_edit_1 = self.findChild(QLineEdit, "lineEdit")
        self.line_edit_2 = self.findChild(QLineEdit, "lineEdit_2")
        self.line_edit_3 = self.findChild(QLineEdit, "lineEdit_3")
        self.text_edit_4 = self.findChild(QTextEdit, "textEdit")
        self.combobox_5 = self.findChild(QComboBox, "comboBox")
        self.combobox_6 = self.findChild(QComboBox, "comboBox_2")
        self.combobox_7 = self.findChild(QComboBox, "comboBox_3")
        self.btn_start = self.findChild(QPushButton, "pushButton")
        self.btn_download = self.findChild(QPushButton, "pushButton_2")
        self.label_for_image = self.findChild(QLabel, "label_2")
        self.label_for_error = self.findChild(QLabel, "label_11")

        self.btn_start.clicked.connect(self.start_generate_image)
        self.btn_download.clicked.connect(self.save_image)

        self.api = FusionBrainAPI(API_URL, API_KEY, SECRET_KEY)
        self.pipeline_id = self.api.get_pipeline()


    def start_generate_image(self):
        self.query_text = ""
        try:
            text_1 = self.line_edit_1.text()
            text_2 = self.line_edit_2.text()
            text_3 = self.line_edit_3.text()
            text_4 = self.text_edit_4.toPlainText()
            text_5 = self.combobox_5.currentText()
            text_6 = self.combobox_6.currentText()
            text_7 = self.combobox_7.currentText()

            if (
                text_1 == None or text_1 == ""
                or text_2 == None or text_2 == ""
                or text_3 == None or text_3 == ""
                or text_4 == None or text_4 == ""
                or text_5 == None or text_5 == ""
                or text_6 == None or text_6 == ""
            ):
                self.label_for_error.setText("Заполните все поля!")

            else:
                self.query_text = f"""Привет, создай для меня аватарку в профиль с такими параметрами:
                Пол моего персонажа {text_7},
                у моего персонажа должна быть {text_1} кожа, 
                {text_2} глаза, волосы должны быть 
                {text_3} цвета, 
                также вот мои отличительные признаки во внешности: {text_4}, 
                я предпочитаю носить {text_5}. 
                Я хочу себе аватарку в {text_6} стиле"""

                self.send_prompt()
            
        except Exception as e:
            print(e)
        
    def send_prompt(self):
        prompt = self.query_text
        try:
            uuid = self.api.generate(prompt, self.pipeline_id)
            base64_image = self.api.check_generation(uuid)
            image_data = base64.b64decode(base64_image)
            self.image = Image.open(io.BytesIO(image_data))
            
            self.text_image = f"{time.time()}.jpeg"
            self.image.save(self.text_image)

            pixmap1 = QPixmap(self.text_image)
            pixmap = self.apply_rounded_mask(pixmap1, 192)

            self.label_for_image.setPixmap(pixmap.scaled(389, 302, Qt.KeepAspectRatio, Qt.SmoothTransformation))       
            self.label_for_error.setText("Готово")

        except Exception as e:
            print(e)
            self.label_for_error.setText(f"Произошла ошибка")

    def apply_rounded_mask(self, pixmap, radius):
        """Создает закругленную маску для QPixmap"""
        size = pixmap.size()
        mask = QBitmap(size)
        mask.fill(Qt.color0)  # Прозрачная маска
        
        painter = QPainter(mask)
        painter.setRenderHint(QPainter.Antialiasing)
        painter.setBrush(Qt.color1)  # Видимая область
        
        # Рисуем закругленный прямоугольник
        path = QPainterPath()
        path.addRoundedRect(0, 0, size.width(), size.height(), radius, radius)
        painter.drawPath(path)
        painter.end()
        
        pixmap.setMask(mask)
        return pixmap

    def save_image(self):
        try:
            file_path, _ = QFileDialog.getSaveFileName(
                None,                          
                "Сохранить изображение",       
                "",                             
                "Images (*.png *.jpg *.bmp)"    
            )

            self.image.save(file_path+self.text_image)
            self.label_for_error.setText("Аватарка успешно\nсохранена")
        except Exception as e:
            print(e)
  
        
if __name__ == '__main__':
    app = QApplication(sys.argv) 
    mainWindow = MainWindow()  
    mainWindow.show() 
    sys.exit(app.exec_()) 


        