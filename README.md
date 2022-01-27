# UpsHelpTool

針對沒有通訊功能的 UPS (例如 APC BV1000)，當意外發生時(停電)，UPS 雖然可以提供一小段時間的電力，但沒有辦法通知 PC，若人不在現場，在 UPS 電池沒電之後，PC 仍然會意外斷電。  

### 核心想法：市電正常時，利用 Relay 讓 RS232 的PIN1-PIN7 短路，否則開路。

* 以 C# 即時監控 RS232 的 PIN1，以達到偵測市電是否正常的目的。
* .net 4.5.2
* 3D列印外殼: https://www.tinkercad.com/things/dkstwTXCMdD  
  
### 照片

![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/UI.jpg)  
![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/1.jpg)
![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/2.jpg)
![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/3.jpg)
![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/4.jpg)
![image](https://github.com/Chihhao/UpsHelpTool/blob/main/Image/5.jpg)  

