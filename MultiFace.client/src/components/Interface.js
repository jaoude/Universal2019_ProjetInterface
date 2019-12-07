import React from 'react';
import HttpRequest from '../Service/httprequest';
import './interface.css';
import 'bootstrap/dist/css/bootstrap.css';

class MyButton extends React.Component {
httpRequest = new HttpRequest();
SQL = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData('0');
  }
CSV = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData('1');
  }
WebService = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData('2');
  }
ClearData = () => {
    document.getElementById('names').innerHTML = "";
   }
render() {
  return (     
      <div>
        <h1 style={ { textAlign: "center", color: "white", fontFamily: "Comic Sans MS"  } }>MultiFace</h1>
        <hr></hr>
        <div className="row" style={{width: "100%"}}>
          <div className="col-2">
            <button  onClick={this.SQL}>SQL Repository</button>{' '}
            <br></br>
            <br></br>
            <button onClick={this.CSV}>CSV Repository</button>{'  '}
            <br></br>
            <br></br>
            <button  onClick={this.WebService}>Service Repository</button>{'  '}
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <button onClick={this.ClearData}>Clear</button>{'  '}
          </div>
          <div className="col data" id='names' hidden={true}>
          </div>
        </div>   
      </div>
    );
  }
}
export default MyButton