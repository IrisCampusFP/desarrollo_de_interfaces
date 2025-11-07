const nombre = document.getElementById("nombre");
const apellidos = document.getElementById("apellidos");
const dni = document.getElementById("dni");
const nie = document.getElementById("nie");
const contenedorInputs = document.getElementById("contenedorInputs")

const radioDni = document.getElementById("radioDni");
const radioNie = document.getElementById("radioNie");

const edad = document.getElementById("edad");
const politica = document.getElementById("politica")
const contenedorNie = document.getElementById("contenedorNie");
const contenedorDni = document.getElementById("contenedorDni");

//ocultar contenedores
// contenedorDni.style.display="none";
// contenedorNie.style.display="none";

radioDni.addEventListener("click", ()=>{
    contenedorDni.style.display="grid";
    contenedorNie.style.display="none";

    contenedorInputs.style.gridTemplateAreas=" 'nombre apellidos' 'edad edad' 'opcion dni' 'politica politica' ";
    nie.value="";
})

radioNie.addEventListener("click", ()=>{
    contenedorDni.style.display="none";
    contenedorNie.style.display="grid";

    contenedorInputs.style.gridTemplateAreas=" 'nombre apellidos' 'edad edad' 'opcion nie' 'politica politica' ";
    dni.value="";
})