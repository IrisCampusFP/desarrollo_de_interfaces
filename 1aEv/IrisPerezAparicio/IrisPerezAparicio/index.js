// Obtengo el formulario 
const form = document.getElementById("form")
// Obtengo el boton
const boton = document.getElementById("boton")

// Obtengo todos los datos mediante su id
const nombre = document.getElementById("nombre")
const apellidos = document.getElementById("apellidos")
const email = document.getElementById("email")
const telefono = document.getElementById("telefono")
const contacto = document.getElementById("contacto")

// Obtengo las claves
const pass1 = document.getElementById("password1")
const pass2 = document.getElementById("password2")

// Inicializo la lista de datos
const listaInputs = []

// Compruebo si las claves coinciden
pass1.addEventListener("change", ()=>{
    if(pass2.value != ""){
        // Si las contraseñas no coinciden se muestra un alert y el botón se desactiva
        if(pass1.value != pass2.value){
            alert("No coincide la clave")
            boton.disabled=true
        }else{ // Cuando las contraseñas coincidan se activará el botón
            boton.disabled=false
        }
    }
})

pass2.addEventListener("change", ()=>{
    if(pass1.value != ""){
        // Si las contraseñas no coinciden se muestra un alert y el botón se desactiva
        if(pass1.value != pass2.value){
            alert("No coincide la clave")
            boton.disabled=true
        }else{ // Cuando las contraseñas coincidan se activará el botón
            boton.disabled=false
        }
    }
})

form.addEventListener("submit", (e)=>{
    e.preventDefault()

    listaInputs.push({id:"nombre", valor:nombre.value})
    listaInputs.push({id:"apellidos", valor:apellidos.value})
    listaInputs.push({id:"email", valor:email.value})
    listaInputs.push({id:"telefono", valor:telefono.value})
    listaInputs.push({id:"usuario", valor:usuario.value})
    listaInputs.push({id:"password1", valor:password1.value})
    listaInputs.push({id:"contacto", valor:contacto.value})

    // Guardo los datos en el almacenamiento local
    localStorage.setItem("datos", JSON.stringify(listaInputs))

    // Muestro los datos en consola
    console.log(localStorage.getItem("datos"))

    
    setTimeout(()=>{
        alert("Datos recibidos correctamente.")
    }, 2000)

})

