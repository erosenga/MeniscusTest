import cv2
import math

cap = cv2.VideoCapture("C:\\Users\\S2\\source\\repos\\MeniscusTest\\MeniscusTest\\run-2022-11-14_05-48-22-PM.mp4")
frameRate = cap.get(5)  # frame rate
while (cap.isOpened()):
    frameId = cap.get(1)  # current frame number
    ret, frame = cap.read()
    if (ret != True):
        break
    if frameId % math.floor(frameRate) == 0:
        filename = str(int(frameId)) + ".bmp"
        cv2.imwrite(filename, frame)
cap.release()
print ("Done!")
