let section2 = document.getElementById("section2");

let articulo = document.createElement("article");
articulo.className = "article";

// Rellenar el artículo con contenido

let tituloinner = "Mi título";
let textoinner = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Soluta ex cum quibusdam maiores quasi vel magnam, possimus provident iusto expedita similique amet veritatis deleniti officiis ipsum autem alias saepe sequi.";
let imageninner = "img/programadores.png";

articulo.innerHTML = `
<div class="titulo">
    <h1>${tituloinner}</h1>
</div>
    
<div class="texto">
    ${textoinner}
</div>

<div class="imagen">
    <img src=${imageninner} alt="Imagen de ejemplo">
</div>`;    

section2.appendChild(articulo);