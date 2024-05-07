fetch('http://consria.net/opw.json')
    .then((response) => response.json())
    .then((json) => {
        var chars = json; 

        for (let i = 0; i < chars.length; i++) {
            console.log(chars[i].name);
            
        }
        document.getElementById("img").innerHTML = "<img src='" + chars[0].img + "' class='resim'>";
        document.getElementById("gender").innerHTML=chars[0].gender;
        document.getElementById("crew").innerHTML=chars[0].crew;
        document.getElementById("df").innerHTML=chars[0].df;
        document.getElementById("haki").innerHTML=chars[0].haki;
        document.getElementById("bounty").innerHTML=chars[0].bounty;
        document.getElementById("origin").innerHTML=chars[0].origin;
        document.getElementById("arc").innerHTML=chars[0].arc;



       
    })
    


    function cloneDiv() {
        // Get the original div
        var originalDiv = document.getElementById('og');

        // Clone the original div
        var clonedDiv = originalDiv.cloneNode(true); // true to clone everything inside
        document.getElementById("img").innerHTML = "<img src='Empty.png' class='resim'>";
        document.getElementById("gender").innerHTML="";
        document.getElementById("crew").innerHTML = "";
        document.getElementById("df").innerHTML = "";
        document.getElementById("haki").innerHTML = "";
        document.getElementById("bounty").innerHTML = "";
        document.getElementById("origin").innerHTML = "";
        document.getElementById("arc").innerHTML = "";
        // Append the cloned div to the document
        document.body.appendChild(clonedDiv);
    }
