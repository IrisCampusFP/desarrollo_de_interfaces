const nombre = document.getElementById("nombre");
const apellidos = document.getElementById("apellidos");
const dni = document.getElementById("dni");
const nie = document.getElementById("nie");
const contenedorInputs = document.getElementById("contenedorInputs")

const radioDni = document.getElementById("radioDni");
const radioNie = document.getElementById("radioNie");

const edad = document.getElementById("edad");
const politica = document.getElementById("politica");
const contenedorNie= document.getElementById("contenedorNie")
const contenedorDni= document.getElementById("contenedorDni")

// const formulario = document.getElementById("miFormulario")

const listaInputs= []
contenedorDni.style.display="grid"
contenedorNie.style.display="none"

radioDni.click(); // .click() hace un click en ese elemento

radioDni.addEventListener("click", ()=>{
    contenedorDni.style.display="grid";
    contenedorNie.style.display="none";    
})

radioNie.addEventListener("click", ()=>{
    contenedorDni.style.display="none";
    contenedorNie.style.display="grid";
})





// formulario.addEventListener("submit", (e)=>{

//     e.preventDefault()
    
//     listaInputs.push({id:"nombre", valor:nombre.value});

//     localStorage.setItem("formData", JSON.stringify(listaInputs));

//     let milista =localStorage.getItem("formData")

//     console.log(milista)
// })