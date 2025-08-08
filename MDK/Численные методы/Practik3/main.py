from PyQt5 import uic
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *
import sys

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        uic.loadUi("ui.ui", self)
        self.setWindowTitle("Сорбало Ангелина")

        self.btn_start = self.findChild(QPushButton, 'btn_start')
        self.btn_end = self.findChild(QPushButton, 'btn_end')
        self.table = self.findChild(QTableWidget, 'tableWidget')
        self.label_x1 = self.findChild(QLabel, 'label_x1')
        self.label_x2 = self.findChild(QLabel, 'label_x2')
        self.label_x3 = self.findChild(QLabel, 'label_x3')
        self.label_x4 = self.findChild(QLabel, 'label_x4')

        self.btn_start.clicked.connect(self.func_start)
        self.btn_end.clicked.connect(self.close)

        self.x1 = 0
        self.x2 = 0
        self.x3 = 0
        self.x4 = 0

    def func_start(self):
        A = []
        for row in range(self.table.rowCount()):
            row_data = []
            for column in range(self.table.columnCount()):
                item = self.table.item(row, column)
                if item is not None:
                    row_data.append(float(item.text()))
                else:
                    row_data.append(0)
            A.append(row_data)
        A_bluestr = []
        for i in A[0]:
          A_bluestr.append(i/A[0][0])
        
        A1 = []
        for i in range(1, len(A)):
            row_data = []
            for j in range(len(A[0])):
                row_data.append(A[i][j] - A_bluestr[j] * A[i][0])
            A1.append(row_data)
        A1_bluestr = []
        for i in A1[0]:
          if i == 0:
              continue
          A1_bluestr.append(i/A1[0][1])
        
        A2 = []
        for i in range(1, len(A1)):
            row_data = []
            for j in range(1, len(A1[0])):
                row_data.append(A1[i][j] - A1_bluestr[j-1] * A1[i][1])
            A2.append(row_data)
        A2_bluestr = []
        for i in A2[0]:
          if i == 0:
              continue
          A2_bluestr.append(i/A2[0][1])

        A3 = []
        for i in range(1, len(A2)):
            row_data = []
            for j in range(1, len(A2[0])):
                row_data.append(A2[i][j] - A2_bluestr[j-1] * A2[i][1])
            A3.append(row_data)
        A3_bluestr = []
        for i in A3[0]:
          if i == 0:
              continue
          A3_bluestr.append(i/A3[0][1])


        self.x1 = A_bluestr[-1] - A3_bluestr[-1] * A_bluestr[-2] - (A2_bluestr[-1] - A3_bluestr[-1] * A2_bluestr[-2]) * A_bluestr[-3] - (A1_bluestr[-1] - A3_bluestr[-1] * A1_bluestr[-2] - (A2_bluestr[-1] - A3_bluestr[-1] * A2_bluestr[-2]) * A1_bluestr[-3]) * A_bluestr[-4]
        self.x2 = A1_bluestr[-1] - A3_bluestr[-1] * A1_bluestr[-2] - (A2_bluestr[-1] - A3_bluestr[-1] * A2_bluestr[-2]) * A1_bluestr[-3]
        self.x3 = A2_bluestr[-1] - A3_bluestr[-1] * A2_bluestr[-2]
        self.x4 = A3_bluestr[-1]

        self.x1 = round(self.x1, 3)
        self.x2 = round(self.x2, 3)
        self.x3 = round(self.x3, 3)
        self.x4 = round(self.x4, 3)

        self.label_x1.setText("X1 = " + str(self.x1))
        self.label_x2.setText("X2 = " + str(self.x2))
        self.label_x3.setText("X3 = " + str(self.x3))
        self.label_x4.setText("X4 = " + str(self.x4))
        

        print(self.x1, self.x2, self.x3, self.x4, sep='\n')


        

    
        

if __name__ == "__main__":
    app = QApplication(sys.argv)
    game = MainWindow()
    game.show()
    sys.exit(app.exec_())