let formulario = document.getElementById("formulario");

let nombre = document.getElementById("nombre");
let apellidos = document.getElementById("apellidos");
let email = document.getElementById("email");
let password = document.getElementById("password");
let fecha = document.getElementById("fecha");
let telefono = document.getElementById("telefono");
let direccion = document.getElementById("direccion");
let ciudad = document.getElementById("ciudad");

let enviar = document.getElementById("enviar");

console.log({ nombre, apellidos, email, password, fecha, telefono, direccion, ciudad, enviar });

enviar.addEventListener("click", (e) => {
  e.preventDefault();

  console.log("Nombre:", nombre.value);
  console.log("Apellidos:", apellidos.value);
  console.log("Email:", email.value);
  console.log("Password:", password.value);
  console.log("Fecha de nacimiento:", fecha.value);
  console.log("Teléfono:", telefono.value);
  console.log("Dirección:", direccion.value);
  console.log("Ciudad:", ciudad.value);

  if (password.value === "123") {
    alert("Contraseña muy fácil");
    document.body.style.background = "#ffdede";
  } else {
    document.body.style.background = "#dfffe6";
  }
});
