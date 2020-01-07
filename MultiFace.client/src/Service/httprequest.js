import './style.css';
class HttpRequest {
  getData = (value) => {
    var xhr = new XMLHttpRequest()
    var a = ''
    xhr.addEventListener('load', () => {
      a = xhr.responseText
      console.log(a)
    })
    xhr.open('GET', 'https://localhost:44370/api/persons/' + value)
    xhr.send()
    xhr.onload = function (e) {
      if (xhr.readyState === 4) {
        if (xhr.status === 200) {
          var json_obj = JSON.parse(xhr.responseText);
          console.log(json_obj)
          document.getElementById('names').innerHTML = "";

          for (var i = 0; i < json_obj.length; i++) {
            
            var div = document.createElement("div");
            div.className = "card";
            div.style="width: 250px; height: 150px; margin-right: 40px;";
            document.getElementById('names').appendChild(div);
            div.innerHTML = 
                "<div class='card-body' style='position: relative; background: #00BCD4; border-radius: 3px; background-position: top center; transform-style: preserve-3d; display: flex; justify-content: center; align-items: center;'>" +   
                  "<img src=" +
                  "data:image/jpeg;base64," + (json_obj[i].photo) + "class='card-img-top' alt='...'>" +
                  " <h5 class='card-title' style='font-family: Impact;'>" + json_obj[i].firstName + " " + json_obj[i].lastName + "</h5>" +
                "</div>"; 
                    
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


