# This is an attempt at making a script to automatically generate assetpackage
# files. This seems like it's very difficult if done from a Windows-based
# environment, and I think it would be much easier in a Linux environment.

UNITY := "/cygdrive/c/Program Files/Unity/Hub/Editor/2018.3.9f1/Editor/Unity.exe"
PROJECT_PATH := $(shell pwd)

FLAGS := "-batchmode -projectPath $(PROJECT_PATH)"

VAR_OBJ_PATH := "Assets/ReachBeyond/Plugins/VariableObjects"

all:
	$(UNITY)

varObj:
	$(UNITY) $(FLAGS) -exportPackage $(VAR_OBJ_PATH) Build/varObj.assetpackage
