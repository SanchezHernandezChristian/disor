function encriptar(){
    var textoplano = document.getElementById("textoplano").value;
    document.getElementById("textoalreves").value = cifrarInverso(textoplano);
    
    if (document.getElementById("desplazamiento").value != ""){
    var desplazamiento = document.getElementById("desplazamiento").value;
    document.getElementById("textocifrado").value = cifrarCesar(textoplano, desplazamiento);
    }

    if (document.getElementById("numerogrupo").value != ""){
        var numerogrupo = document.getElementById("numerogrupo").value;
        document.getElementById("textoalrevesgrupo").value = cifrarInversoGrupo(textoplano, numerogrupo);
        }
}
  