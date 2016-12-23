from flask import Flask
from flask import render_template
import Tkinter
import threading
import time

HOST = '0.0.0.0'
PORT = int(5000)
STARTED = False

def start_button_text():
    if STARTED:
        return "Stop"
    else:
        return "Start"
    
app = Flask(__name__)

@app.route("/")
def index():
    return render_template("index.html");

@app.route("/image")
def get_screen():
    import subprocess
    process = subprocess.Popen(["./printscreen.exe"], stdout=subprocess.PIPE)
    result = process.communicate()[0]
    return result.encode("base64")

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000, debug = False)
