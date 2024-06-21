let productosEnFactura = [];
let totalPagar = 0;

function agregarProducto() {
    const productoId = $('#productoId').val();
    const cantidad = $('#cantidad').val();

    if (productoId && cantidad > 0) {
        const producto = obtenerProductoPorId(productoId);
        const subtotal = producto.Precio * cantidad;

        productosEnFactura.push({
            Id: producto.Id,
            Nombre: producto.Nombre,
            Descripcion: producto.Descripcion,
            Precio: producto.Precio,
            Cantidad: cantidad,
            Subtotal: subtotal
        });

        actualizarTabla();
        calcularTotal();
    } else {
        alert('Seleccione un producto y cantidad válida.');
    }
}

function obtenerProductoPorId(id) {
    // Esta función debería obtener el producto por Id desde tu fuente de datos
    // Aquí hay un ejemplo básico con datos estáticos
    const productos = [
        { Id: 1, Nombre: 'Mantequilla', Descripcion: '1 libra', Precio: 25.00 },
        { Id: 2, Nombre: 'Arina', Descripcion: '1 saco de arina', Precio: 300.00 },
        { Id: 3, Nombre: 'Azucar', Descripcion: '1 libra', Precio: 30.00 },
        { Id: 4, Nombre: 'Levadura', Descripcion: '1 libra', Precio: 24.00 },
        { Id: 5, Nombre: 'Sopa de Marisco', Descripcion: 'rikitiksi', Precio: 108.00 },
    ];
    return productos.find(p => p.Id == id);
}

function actualizarTabla() {
    const tbody = $('#tablaFactura tbody');
    tbody.empty();
    productosEnFactura.forEach((producto, index) => {
        tbody.append(`
            <tr>
                <td>${producto.Id}</td>
                <td>${producto.Nombre}</td>
                <td>${producto.Descripcion}</td>
                <td>${producto.Precio.toFixed(2)}</td>
                <td>${producto.Cantidad}</td>
                <td>${producto.Subtotal.toFixed(2)}</td>
                <td>
                    <button class="btn btn-sm btn-danger" onclick="confirmarEliminar(${index})">Eliminar</button>
                </td>
            </tr>
        `);
    });
}

function calcularTotal() {
    totalPagar = productosEnFactura.reduce((total, producto) => total + producto.Subtotal, 0);
    $('#totalPagar').text(totalPagar.toFixed(2));
}

function confirmarEliminar(index) {
    $('#confirmarEliminarModal').modal('show');
    $('#confirmarEliminarModal').data('index', index);
}

function eliminarProducto() {
    const index = $('#confirmarEliminarModal').data('index');
    productosEnFactura.splice(index, 1);
    actualizarTabla();
    calcularTotal();
    $('#confirmarEliminarModal').modal('hide');
}

function finalizarFactura() {
    // Aquí puedes implementar la lógica para finalizar la factura
    alert('Factura finalizada. Total a pagar: $' + totalPagar.toFixed(2));
    productosEnFactura = [];
    actualizarTabla();
    calcularTotal();
}