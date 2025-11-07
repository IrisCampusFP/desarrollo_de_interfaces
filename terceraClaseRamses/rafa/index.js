const formulario = document.getElementById("formulario")

const nombre = document.getElementById("nombre")
const apellidos = document.getElementById("apellidos")
const dni = document.getElementById("dni")
const nie = document.getElementById("nie")
const radioDni = document.getElementById("radioDni")
const radioNie = document.getElementById("radioNie")
const edad = document.getElementById("edad")
const politica = document.getElementById("politica")
const contendorNie = document.getElementById("contenedorNie")
const contendorDni = document.getElementById("contenedorDni")

const contenedorInputs = document.getElementById("contenedorInputs")

contendorDni.style.display = "grid"
contendorNie.style.display = "none"

const listaInputs= []


radioDni.addEventListener("click", () => {

    contendorDni.style.display = "grid";
    contendorNie.style.display = "none";
    // contenedorInputs.style.gridTemplateAreas = ' "nombre apellidos" "edad edad" "opcion opcion" " dninie dninie" "politica politica"  '
    nie.value = "";

})
radioNie.addEventListener("click", () => {

    contendorNie.style.display = "grid";
    contendorDni.style.display = "none";
    dni.value = "";

})

formulario.addEventListener("submit", (e)=>{
    e.preventDefault()

    listaInputs.push({id:"nombre", valor:nombre.value})
    listaInputs.push({id:"apellidos", valor:apellidos.value})
    listaInputs.push({id:"edad", valor:edad.value})
    listaInputs.push({id:"politica", valor:politica.value})

    if(radioDni.checked) {
        listaInputs.push({id:"dni", valor:dni.value})
    }
    if(radioNie.checked) {
        listaInputs.push({id:"nie", valor:nie.value})
    }

    localStorage.setItem("misDatos", JSON.stringify(listaInputs))

    console.log(localStorage.getItem("misDatos"))

    setInterval(hola(), 3000)
    
    setTimeout(()=>{

        alert("tengo tus datos")

    }, 5000)
})

function hola(){
    console.log("hola")

}