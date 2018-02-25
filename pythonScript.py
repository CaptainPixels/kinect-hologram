#import maya.cmds as cmds
import time

running = 0
multiplyer = 20
frames = 10

while running <= frames:
    filename = 'C:\\Users\\Corbin Pixels\\Desktop\\kinect\\FaceTrackingBasics-WPF\\coords.txt'
    file = open(filename, "r")
      coords = file.read()
    #print(coords)
    coordXstr = coords[:coords.find('@x')]
    coordYstr = coords[coords.find('@x')+3:coords.find('@y')]
    coordZstr = coords[coords.find('@y')+3:coords.find('@z')]
    if coordXstr and coordYstr and coordZstr != '': 
        coordX = round(multiplyer*float(coordXstr),3)
        coordY = round(multiplyer*float(coordYstr),3)
        coordZ = round(multiplyer*float(coordZstr),3)
        print('X:', coordX, 'Y:', coordY, 'Z:', coordZ)
        #cmds.move(coordX, coordY, coordZ, 'camera1')
    time.sleep(.05)
    running = running + 1
