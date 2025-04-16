# Запуск проекта
Для запуска потребуется Docker Desktop. В главной директории проекта есть файл *compose.yml*. Находясь в это директории нужно вызвать команду 

```
docker-compose up -d
```

Postgres база данных будет доступна по порту 5433 от имени postgres с паролем password@123

PgAdmin4 будет доступен по ссылке http://localhost:5050/browser/

Бэкенд по ссылке http://localhost:8000. Сваггер по пути http://localhost:8000/swagger/index.html

# Ресурсы
## Франшизы/Фандомы
**GET /franchises** 

Возвращает список всех франшиз:

```json
[
  {
    "id": "638366e4-0701-4872-a9b3-94c95494b54a",
    "title": "Naruto",
    "description": "Manga Franchise"
  },
  {
    "id": "85ae4d0b-51af-4b65-9f60-3fce549f64c1",
    "title": "Marvel",
    "description": "Comic Franchise"
  },
  {
    "id": "cf45d0e0-8db9-4772-afc5-ad03f667ac43",
    "title": "DC",
    "description": "Comic Franchise"
  }
]
```

**GET /franchises?guid={id}** 

Возвращает одну франшизу по *id*.

**GET /franchises?name={name}**

Возвращает список франшиз, которые имеют в списке вариаций своего названия строку *name*.

**POST /franchises**
```json
{
  "name": "string",
  "description": "string",
  "additionalNames": [
    "string"
  ]
}
```
Создает новую франшизу с главным именем, описанием и дополнительными именами для поиска. Возвращает id созданной франшизы.

## Тесты
**GET /tests**

Возвращает список тестов с тегами, вопросами, ответами и рейтингом. 

```json
[
  {
    "id": "05e7aff5-69e8-4b02-9812-78a738710c14",
    "title": "string",
    "description": "string",
    "questions": [
      {
        "id": "16e4dd02-be30-4b66-8a15-b4fee86d7499",
        "text": "string",
        "options": [
          {
            "id": "22097e47-2e35-42de-b0de-ddf58a9d21a1",
            "text": "string",
            "characterOrder": 0
          }
        ]
      }
    ],
    "tags": [
      {
        "tagId": "869c5d9c-773b-4102-a422-14d721732e0f",
        "tagName": "string"
      }
    ],
    "score": 0,
    "ratingCount": 0
  }
]
```

**GET /tests?guid={id}** 

Возвращает тест по *id*.

**GET /tests?name={name}**

Возвращает список тестов, содержащие в своем названии *name*.

**GET /tests?franchise={franchise}**, где franchise это строка.

Возвращает список тестов, в которых фигурируют персонажи из данного фандома.

**GET /tests?orderBy={order}**, где order это строка.

Возвращает отсортированный список тестов по рейтингу. "rating" сортирует по возврастанию, "ratingDesc" - по убыванию.

**GET /tests?tags={tag1}&tags={tag2}**

Возвращает список тестов, которые имеют среди тегов tag1 и tag2.

**POST /tests**
```json
{
  "title": "string",
  "description": "string",
  "questions": [
    {
      "text": "string",
      "options": [
        {
          "text": "string",
          "characterOrder": 0
        }
      ]
    }
  ],
  "charactersId": [
    "3fa85f64-5717-4562-b3fc-2c963f66afa6"
  ],
  "tagsId": [
    "3fa85f64-5717-4562-b3fc-2c963f66afa6"
  ]
}
```

**POST /tests/pass**

```json
{
  "testId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "selectedOptions": [
    "3fa85f64-5717-4562-b3fc-2c963f66afa6"
  ]
}
```
Прохождение теста. selectedOptions - id вариантов ответов теста, выбранные пользователем. Отправляет результат теста.


**PUT /tests/{id}/rate?rate={rate}**, где id - идентификатор теста, а rate - число от 0 до 5
Добавляет оценку к тесту. 

Создает новый тест. В тесте есть массив вопросов, в каждом вопросе несколько ответов (options) >2. Ответы (options) должны ссылаться на элемент из массива персонажей как на индекс. 
Возвращает id созданного теста.

# Теги
**GET /tags**

Возвращает массив тегов:
```json
[
  {
    "tagId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
    "tagName": "string"
  }
]
```

**POST /tags**

```json
{
  "name": "string"
}
```

Создает тег и возвращает его id.
