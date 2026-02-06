if(document.getElementById("contenedor")){
    let contenedor = document.getElementById("contenedor");

    // Consumir personas
    fetch("http://localhost:5159/personas")
        .then(res => res.ok ? res.json() : null)
        .then(todos => {
            if(todos){
                console.log(todos); // Compruebo que llegan los datos mostrándolos por consola
                todos.forEach(persona => {
                    contenedor.innerHTML += `
                        <div class="card">
                            <div class="titulo">
                                <h2>${persona.id} ${persona.nombre} ${persona.apellidos}</h2>
                            </div>
                            <div class="info">
                                <p>DNI: ${persona.dni}</p>
                                <p>Edad: ${persona.edad}</p>
                                <p>Lugar: ${persona.lugarNacimiento}, ${persona.paisNacimiento}</p>
                                <p>Dirección: ${persona.direccion}</p>
                                <p>Estudios: ${persona.ultimoEstudio}</p>
                            </div>
                            <div class="botones">
                                <button style="background:green;" onClick="editarPersona('${persona.dni}')">EDITAR</button>
                                <button onClick="eliminarPersona(${persona.id})">ELIMINAR</button>
                            </div>
                        </div>
                    `;
                });
            }
        });

    function eliminarPersona(id){
        if(confirm("Quieres eliminar la persona?")){
            fetch(`http://localhost:5159/personas/${id}`, {
                method: "DELETE"
            }).then(() => location.reload());
        }
    }
}

function editarPersona(dni){
    fetch(`http://localhost:5159/personas/${dni}`)
        .then(res => res.ok ? res.json() : null)
        .then(datos => {
            if(!datos) return;

            document.getElementById("contenedor").style.display = "none";
            location.href = "#formulario";

            document.getElementById('idInput').value = datos.id;
            document.getElementById('nombreInput').value = datos.nombre;
            document.getElementById('apellidosInput').value = datos.apellidos;
            document.getElementById('edadInput').value = datos.edad;
            document.getElementById('dniInput').value = datos.dni;
            document.getElementById('lugarInput').value = datos.lugarNacimiento;
            document.getElementById('paisInput').value = datos.paisNacimiento;
            document.getElementById('direccionInput').value = datos.direccion;
            document.getElementById('estudioInput').value = datos.ultimoEstudio;
        });
}

if(document.getElementById('formulario')){
    let formulario = document.getElementById('formulario');

    formulario.addEventListener('submit', e => {
        e.preventDefault();

        let persona = {
            id: Number(document.getElementById('idInput').value),
            nombre: document.getElementById('nombreInput').value,
            apellidos: document.getElementById('apellidosInput').value,
            edad: Number(document.getElementById('edadInput').value),
            dni: document.getElementById('dniInput').value,
            lugarNacimiento: document.getElementById('lugarInput').value,
            paisNacimiento: document.getElementById('paisInput').value,
            direccion: document.getElementById('direccionInput').value,
            ultimoEstudio: document.getElementById('estudioInput').value
        };

        if(persona.id){ 
            // EDITAR
            fetch(`http://localhost:5159/personas/`, {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(persona)
            }).then(() => location.reload());
        } else { 
            // CREAR
            fetch("http://localhost:5159/personas", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(persona)
            }).then(() => location.reload());
        }
    });
}
