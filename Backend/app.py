from flask import Flask, jsoinfy
import pandas as pd

app = Flask(__name__)

@app.route('/rankings', methods=['GET'])

def get_rankings():
    #cargar datos de json despues de entrenar el modelo
    data = pd.read_json('data/ranked_players.json')
    return jsoinfy(data.to_dict(orient='records'))

if __name__ == '__main__':
    app.run(debug = True, port=5000)