# Progress Terra Test Task 2021
## Solution by MainDen

Есть сущность RGDialogsClients. Она предназначена для хранения информации о том, какие пользователи взаимодействуют в рамках одного диалога.
Т.е. может быть N-ое количество IDClient, объединенных одним диалогом.
Функция Init позоволяет получить набор сущностей, с которыми можно производить операции.

Задача

Написать проект WebAPI в котором будет реализован метод API поиска диалога с теми идентификаторами клиентов, которые были переданы в метод.
Метод должен принимать список идентфикаторов клиентов для которых необходимо найти диалог. Нужно найти такой диалог, в котором есть все переданные клиенты. Если такого диалога нет, то возвращается пустой GUID.
Если диалог найден возвращается идентификатор диалога.
Метод должен быть описан в соотвествии со стандартом OpenAPI и доступен через SwaggerUI

Класс iMessengerCoreAPI.Models.RGDialogsClients задан изначально.

## Run

1. Запустите iMessengerWebAPI.exe
2. Откройте в веб-браузере страницу http://localhost:5000/swagger/index.html