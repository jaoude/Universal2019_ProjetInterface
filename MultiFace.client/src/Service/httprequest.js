class HttpRequest {

  ClearBox = () => {
    document.getElementById('data').innerHTML = "";
   }
  getData = () => {
    // create a new XMLHttpRequest
    var xhr = new XMLHttpRequest()
    var a = ''
    // get a callback when the server responds
    xhr.addEventListener('load', () => {
      // update the state of the component with the result here
      a = xhr.responseText
      console.log(a)
    })
    // open the request with the verb and the url
    xhr.open('GET', 'https://localhost:44370/api/persons/sql')
    // send the request
    xhr.send()
    xhr.onload = function (e) {
      if (xhr.readyState === 4) {
        if (xhr.status === 200) {
          var json_obj = JSON.parse(xhr.responseText);
          console.log(json_obj)
          document.getElementById('names').innerHTML = "";
          
          for(var i = 0; i < json_obj.length; i++)
          {
            var div = document.createElement("div");
            var p = document.createElement("P"); 
            var img = document.createElement('img');
            img.src = 'data:image/jpeg;base64,' + (json_obj[i].photo);
            p.innerHTML= '<div class="data"><p id="Data"></p>'+ json_obj[i].firstName + " " + json_obj[i].lastName  + "</p></div>";
            div.appendChild(p);
            p.appendChild(img);
            document.getElementById('names').appendChild(div);
          }
       
        } else {
          console.error(xhr.statusText);
        }
      }
    }
    xhr.onerror = function (e) {
      console.error(xhr.statusText);
    };
    
  }
}


export default HttpRequest;