-- 1. Insertar Tipos de Servicio
-- Como los ID se generan solos, el primero será 1, el segundo 2, etc.
INSERT INTO TipoServicio (Nombre, PrecioBase)
VALUES
    ('Cambio de Aceite y Filtro', 85.50),
    ('Mantenimiento Preventivo', 150.00),
    ('Alineación y Balanceo', 120.00),
    ('Revisión de Frenos', 90.00),
    ('Reparación de Motor', 2500.00);
GO

-- 2. Insertar Clientes
-- CORREGIDO: Cambiado 'Nombre' por 'Nombres' para que coincida con la tabla original
INSERT INTO Cliente (Paterno, Materno, Nombres, Correo, Telefono)
VALUES
    ('Pérez', 'Gómez', 'Juan', 'juan.perez@email.com', '555-0101'),     -- ClienteId: 1
    ('López', 'Díaz', 'María', 'maria.lopez@email.com', '555-0202'),    -- ClienteId: 2
    ('García', 'N/A', 'Carlos', 'carlos.garcia@email.com', '555-0303'),  -- ClienteId: 3 (No permite NULL según diseño, se pone 'N/A')
    ('Rodríguez', 'Silva', 'Ana', 'ana.rod@email.com', '555-0404');     -- ClienteId: 4
GO

-- 3. Insertar Vehículos
-- Nos aseguramos de usar los ClienteId (1, 2, 3, 4) que acabamos de generar
INSERT INTO Vehiculo (Placa, Marca, Modelo, Anio, ClienteId)
VALUES
    ('ABC-123', 'Toyota', 'Corolla', 2018, 1),  -- Vehículo de Juan
    ('XYZ-987', 'Honda', 'Civic', 2021, 2),     -- Vehículo de María
    ('DEF-456', 'Ford', 'Ranger', 2015, 3),     -- Vehículo de Carlos
    ('LMN-741', 'Nissan', 'Versa', 2022, 1);    -- Segundo vehículo de Juan
GO

-- 4. Insertar Órdenes de Servicio
-- Usamos VehiculoId (1, 2, 3, 4) y TipoServicioId (1, 2, 3, 4, 5)
INSERT INTO OrdenServicio (FechaIngreso, DescripcionProblema, CostoEstimado, Estado, VehiculoId, TipoServicioId)
VALUES
    -- Orden para el Corolla (VehiculoId: 1) para Cambio de Aceite (TipoServicioId: 1)
    ('2026-05-25 08:30:00', 'El cliente solicita cambio de aceite sintético.', 95.00, 'Completado', 1, 1),
    
    -- Orden para el Civic (VehiculoId: 2) para Mantenimiento (TipoServicioId: 2)
    ('2026-05-27 10:15:00', 'Mantenimiento de los 50,000 km.', 150.00, 'En Progreso', 2, 2),
    
    -- Orden para la Ranger (VehiculoId: 3) para Reparación de Motor (TipoServicioId: 5)
    ('2026-05-28 09:00:00', 'Motor hace ruido metálico al acelerar y pierde fuerza.', 2800.00, 'Pendiente', 3, 5),
    
    -- Orden para el Versa (VehiculoId: 4) para Alineación (TipoServicioId: 3)
    (GETDATE(), 'El volante vibra a más de 80 km/h.', 120.00, 'Pendiente', 4, 3);
GO