# ApiCatalagoJWT
A `ConnectionStrings` está setada para o banco MySQL.\
Para gerar o banco de dados, basta rodar o migrations na pasca local:
### `add-migrations Initial`
### `update-database`
Para salvar futuras alterações:
### `dotnet ef migrations add InitialCreate`
### `dotnet ef database update`
