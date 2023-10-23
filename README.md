
## 📝 Task requirements

- [Requirements document](task.pdf)
- [Deployment](#deployment)

## 🧐 About <a name = "about"></a>

Write about 1-2 paragraphs describing the purpose of your project.

## 🏁 Getting Started <a name = "getting_started"></a>
Backed mostly using PostgreSQL as relational/document storage and Amazon S3 as blob storage.

API Signature

Post /tibber-developer-test/enter-path

Request body
```json
{
  "start":{
    "x": 10,
    "y", 22
  },
  "commands":[
    {
      "direction":"east",
      "steps": 2
    },
    {
      "direction":"north",
      "steps":1
    }
  ]
  }
  ```
