import React from 'react';
import HttpRequest from '../Service/httprequest';
import './interface.css';
import 'bootstrap/dist/css/bootstrap.css';

class MyButton extends React.Component {
httpRequest = new HttpRequest();
click = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData('0');
  }
ClearBox = () => {
    document.getElementById('names').innerHTML = "";
   }
click1 = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData('1');
  }
design = {
    width: '1800px',
  };
render() {
  return (     
      <div>
        <h1 style={ { textAlign: "center" } }>MultiFace</h1>
        <hr></hr>
        <div className="row" style={this.design}>
          <div className="col">
            <button  onClick={this.click}>SQL Repository</button>{' '}
            <br></br>
            <br></br>
            <button onClick={this.click1}>CSV Repository</button>{'  '}
            <br></br>
            <br></br>
            <button>Service Repository</button>{'  '}
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <button onClick={this.ClearBox}>Clear</button>{'  '}
          </div>
          <div className="row" id='names' hidden={true}>
            <div className="col" id="names" hidden ={true}>
            </div>
          </div>
        </div>   
      </div>
    );
  }
}
export default MyButton