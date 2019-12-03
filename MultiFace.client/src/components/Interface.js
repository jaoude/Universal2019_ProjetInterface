import React from 'react';
import HttpRequest from '../Service/httprequest';
//import './interface.css';

class MyButton extends React.Component {
 httpRequest = new HttpRequest();
  
 click = ()=>{
    document.getElementById('names').hidden=false;
    this.httpRequest.getData();
  }
  ClearBox = () => {
    document.getElementById('names').innerHTML = "";
   }

  render() {
    return (
      
      <div>
        
        <h1 style={ { textAlign: "center" } }>MultiFace</h1>
        <hr></hr>
        <div className="row">

          <div className="col">
            <button onClick={this.click}>Service Repository</button>{' '}
            <br></br>
            <br></br>
            <button>CSV   Repository</button>{'  '}
            <br></br>
            <br></br>
            <button>SQL   Repository</button>{'  '}
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <br></br>
            <button onClick={this.ClearBox}>Clear</button>{'  '}
          </div>

          <div className="col names" id='names' hidden={true}>
            {/* <div style={this.dataStyle()}>
              <p id='Data'></p>
            </div> */}
          </div>

        </div>
        
      </div>
    );
  }
}
export default MyButton;