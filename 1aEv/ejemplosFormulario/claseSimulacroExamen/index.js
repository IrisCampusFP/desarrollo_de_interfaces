const pass1 = document.getElementById("exampleInputPassword1")
const pass2 = document.getElementById("exampleInputPassword2")

const form = document.getElementById("form")
const boton = document.getElementById("boton")


pass1.addEventListener("change", ()=>{
    console.log(pass1.value, pass2.value)
    if(pass2.value != ""){
        if(pass1.value != pass2.value){
            alert("las contraseñas no son iguales")
            boton.disabled=true
        }else{
            boton.disabled=false
        }
    }
})

pass2.addEventListener("change", ()=>{
    console.log(pass1.value, pass2.value)
    if(pass1.value != ""){
        if(pass1.value != pass2.value){
            alert("las contraseñas no son iguales")
            boton.disabled=true
        }else{
            boton.disabled=false
        }
    }
})

