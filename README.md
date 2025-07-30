# 🏥 TestTask.MaternityHospital

REST API-сервис для управления данными пациентов — часть тестового задания.

## 📦 Стек технологий

- ASP.NET Core 6.0
- Entity Framework Core
- MySQL
- Docker + Docker Compose
- Swagger (OpenAPI)
- Postman (коллекция запросов)

---

## 🚀 Быстрый старт

> Требования:
> - [Docker](https://www.docker.com/products/docker-desktop)
> - Git

### 🔧 Запуск в Docker

1. Клонировать проект:

   ```bash
   git clone https://github.com/AlexeyMalashenko/TestTask.MaternityHospital.git
   cd TestTask.MaternityHospital
   ```

2. Собрать и запустить контейнеры:

   ```bash
   docker-compose up --build
   ```

3. API будет доступно по адресу:
   - http://localhost:5000

4. Swagger UI:
   - http://localhost:5000/swagger

---

## 🧪 Тестирование API

✅ В проекте есть коллекция запросов для Postman:

📁 [`postman/PatientAPI.postman_collection.json`](postman/PatientAPI.postman_collection.json)

Сценарии, покрытые в коллекции:

- Добавление пациента
- Обновление пациента
- Получение по ID
- Удаление пациента
- Поиск по параметру `birthDate` (и другие варианты)

📌 **Как использовать:**

1. Открыть [Postman](https://www.postman.com/downloads/)
2. Импортировать файл:
   - `File > Import > postman/PatientAPI.postman_collection.json`

---

## ⚙️ Конфигурация подключения к БД

Настраивается в `docker-compose.yml` через переменные окружения:

```yaml
environment:
  - ConnectionStrings__DefaultConnection=Server=db;Port=3306;Database=db_maternity_hospital;Uid=admin;Pwd=admin;
```

---

## 💡 Полезные команды

```bash
# Остановка контейнеров
docker-compose down

# Перезапуск после изменений
docker-compose up --build

# Просмотр логов
docker-compose logs -f
```

---

## 📁 Структура проекта

```
TestTask.MaternityHospital/
├── .docker/                      # Скрипты для запуска
├── Libs/                         # Общие библиотеки (домен, провайдеры, загрузчики)
├── TestTask.MaternityHospital.App/      # Web API
├── docker-compose.yml
├── Dockerfile
├── postman/
│   └── PatientAPI.postman_collection.json
└── README.md
```

---

## 📃 Лицензия

Проект создан в рамках тестового задания. Свободно используйте, адаптируйте и дорабатывайте.
