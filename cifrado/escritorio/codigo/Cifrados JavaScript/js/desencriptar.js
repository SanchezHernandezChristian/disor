function desencriptar(){
    if (document.getElementById("desplazamiento").value != ""){
        var textocifrado = document.getElementById("textocifrado").value;
        var desplazamiento = document.getElementById("desplazamiento").value;
        document.getElementById("textoplano").value = descifrarCesar(textocifrado, desplazamiento);
    }
}