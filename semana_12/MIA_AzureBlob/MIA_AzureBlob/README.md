# MIA Azure Blob

## 4. Seguridad

La Connection String y la Account Key contienen información sensible. No deben publicarse en GitHub ni compartirse en repositorios, capturas o mensajes.

### Recomendación

- No codifiques la clave directamente en el código fuente.
- Usa variables de entorno o un archivo local que esté ignorado por Git.
- Mantén el archivo `appsettings.Development.json` solo en tu máquina local.
- Añade siempre un `.gitignore` para evitar subir secretos.

### Ejemplo en Windows PowerShell

```powershell
$env:AZURE_STORAGE_ACCOUNT_NAME = "tu-cuenta-de-almacenamiento"
$env:AZURE_STORAGE_ACCOUNT_KEY = "tu-account-key"
```

### Importante

- Nunca subas la clave ni la connection string a GitHub.
- Si usas `appsettings.Development.json`, asegúrate de que esté listado en `.gitignore`.
- En un entorno real, se recomienda usar Azure Key Vault o variables del sistema para gestionar secretos con mayor seguridad.

Este proyecto ya está preparado para leer primero la variable de entorno y, si no existe, buscar la configuración local sin comprometer credenciales.
