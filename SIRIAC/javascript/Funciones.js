
function show(obj) {
            var DTNOTAS = document.getElementById(obj);
            var imageID = document.getElementById('imagen' + obj);
            if (DTNOTAS.style.display == "none") {
                DTNOTAS.style.display = "inline";
                imageID.src = "Estilos/Imagenes/minus.gif";
            }
            else {
                DTNOTAS.style.display = "none";
                imageID.src = "Estilos/Imagenes/plus.gif";
            }
};
function showen(obj) {
    var DTNOTAS = document.getElementById(obj);
    var imageID = document.getElementById('imagen' + obj);
    if (DTNOTAS.style.display == "none") {
        DTNOTAS.style.display = "inline";
        imageID.src = "Estilos/Imagenes/minus.gif";
    }
    else {
        DTNOTAS.style.display = "none";
        imageID.src = "Estilos/Imagenes/plus.gif";
    }
};


