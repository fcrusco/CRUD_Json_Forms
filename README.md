## 🇧🇷 Resumo Funcional e Técnico

Esta aplicação Windows Forms em **C# (.NET 8)** implementa um **CRUD (Create, Read, Update, Delete)** simples utilizando **JSON** como base de dados.  

<img width="714" height="336" alt="image" src="https://github.com/user-attachments/assets/dd6e078b-468f-4b7e-a60f-12eba9a550c3" />


### Funcional
- Cadastro de pessoas com os campos **Nome** e **Sobrenome**.  
- Listagem de todos os registros em um **ListBox**.  
- Edição de registros através da seleção na lista.  
- Exclusão de registros com confirmação.  
- Armazenamento automático em arquivo `pessoas.json`, criado dentro da pasta `data`.  

### Técnico
- Desenvolvido em **C# com .NET 8**.  
- Interface construída com **Windows Forms Designer** (modelo padrão, não minimalista).  
- Estrutura de dados: classe `Pessoa` contendo propriedades `Id` (GUID), `Nome` e `Sobrenome`.  
- Serialização/desserialização com `System.Text.Json`.  
- Uso de `try/catch` em todos os métodos para tratamento de erros.  
- Persistência garantida em arquivo JSON, permitindo reutilização dos dados entre execuções.  

---

## 🇺🇸 Functional and Technical Summary

This Windows Forms application in **C# (.NET 8)** implements a simple **CRUD (Create, Read, Update, Delete)** using **JSON** as the data store.  

### Functional
- Register people with **First Name** and **Last Name** fields.  
- Display all records in a **ListBox**.  
- Edit records by selecting them from the list.  
- Delete records with confirmation.  
- Automatic storage in `pessoas.json`, created inside the `data` folder.  

### Technical
- Developed in **C# with .NET 8**.  
- Interface built with **Windows Forms Designer** (standard model, not minimalist).  
- Data structure: `Pessoa` class with properties `Id` (GUID), `FirstName`, and `LastName`.  
- Serialization/deserialization handled with `System.Text.Json`.  
- All methods wrapped in `try/catch` blocks for error handling.  
- Persistent storage in a JSON file, ensuring data is kept between sessions.  

---

## 🇪🇸 Resumen Funcional y Técnico

Esta aplicación de Windows Forms en **C# (.NET 8)** implementa un **CRUD (Crear, Leer, Actualizar, Eliminar)** sencillo utilizando **JSON** como base de datos.  

### Funcional
- Registro de personas con los campos **Nombre** y **Apellido**.  
- Listado de todos los registros en un **ListBox**.  
- Edición de registros seleccionándolos en la lista.  
- Eliminación de registros con confirmación.  
- Almacenamiento automático en `pessoas.json`, creado dentro de la carpeta `data`.  

### Técnico
- Desarrollado en **C# con .NET 8**.  
- Interfaz construida con **Windows Forms Designer** (modelo estándar, no minimalista).  
- Estructura de datos: clase `Pessoa` con propiedades `Id` (GUID), `Nombre` y `Apellido`.  
- Serialización/desserialización con `System.Text.Json`.  
- Todos los métodos incluyen `try/catch` para el manejo de errores.  
- Persistencia en archivo JSON, asegurando la conservación de los datos entre ejecuciones.  
