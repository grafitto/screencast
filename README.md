# ScreenCast

Just did this as a simple challange with [Clement Habinshuti](https://www.github.com/habbes) on who will have the best program that broadcasts 
the desktop over the network. I decided to use Python (Flask) and .NET's C#.

I will take you through installation and running of these scripts on your computer:

## Install python

Download python 2.7.* from [Python Official Website](https://www.python.org/downloads/) and install it

### Install virtualenv

Run: 
```
C:\> pip install virtualenv
```
on your terminal


After downloading is complete, you can now clone the project
```
C:\working\directory> git clone https://github.com/grafitto/screencast.git
```
This will create a folder named _screencast_, change your directory to the folder

```
C:\working\directory>cd screencast
```
```
  C:\working\directory\screencast> virtualenv env
```
that creates a python virtual environment called "env".
After that you need to activate your virtual environment by navigating to: 
```
C:\working\directory\screencast> cd env/Scripts/
``` 
then run: 
```
C:\working\directory\screencast\env\Scripts> activate
``` 
to activate your virtual environment 'env'.

Your terminal will change to something like:
```
(env) C:\working\directory\screencast\env\Scripts>
```
Go back 2 directories:
```
(env) C:\working\directory\screencast\env\Scripts> cd ../..
```
to get back to your working directory...

### Install python _flask_ library

```
(env) C:\working\directory\screencast> pip install python-fl
```

You can now proceed to start the python script:

```
(env) C:\working\directory\screencast> cd server
(env) C:\working\directory\screencast> python main.py
```
If you should see this if your setup was successfull:
```
* Running on http://0.0.0.0:5000/ (Press CTRL+C to quit)
```

##### AOB
There is an executable file in the `/server` directory. The file is used to get the esktop image

If you would like to compile your own you can use the Printscreen.cs in the same directory and replace the executable file. Make sure the name remains _printscreen.exe_

Now you can use anyone can use you IP address and port 5000 in a network to view your desktop

# Happy ScreenCasting :smile:


