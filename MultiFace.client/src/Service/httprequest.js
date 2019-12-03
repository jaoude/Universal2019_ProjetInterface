class HttpRequest {
  getData = (value) => {
    var xhr = new XMLHttpRequest()
    var a = ''
    // get a callback when the server responds
    xhr.addEventListener('load', () => {
      // update the state of the component with the result here
      a = xhr.responseText
      console.log(a)
    })
    // open the request with the verb and the url
    xhr.open('GET', 'https://localhost:44370/api/persons/' + value)
    // send the request
    xhr.send()
    xhr.onload = function (e) {
      if (xhr.readyState === 4) {
        if (xhr.status === 200) {
          var json_obj = JSON.parse(xhr.responseText);
          console.log(json_obj)
          document.getElementById('names').innerHTML = "";

          for (var i = 0; i < json_obj.length; i++) {
            var div = document.createElement("div");
            document.getElementById('names').appendChild(div);
            div.innerHTML = 
            "<div class='row' style='width: 400px;'>" +
            "<div class='col'>" +
              "<div class='card' style='width: 300px;'>" +
                "<div class='card-body'>" +
                  "<img src=" +
                  "data:image/jpeg;base64," + (json_obj[i].photo) + "class='card-img-top' alt='...'>" +
                  " <h5 class='card-title'>" + json_obj[i].firstName + " " + json_obj[i].lastName + "</h5>" +
                "</div>" +
              "</div>" +
            "</div>" +
          "</div>" 
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


