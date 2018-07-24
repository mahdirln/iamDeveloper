**Address**
----
* **URL**
  /address/GetById

* **Method:**
    `GET`
*  **URL Params**<br/>
   `id=[integer]`
    *address id*<br/>
   `languageId=[integer]`
    *language id*<br/>
*   **Required:**
    `id=[integer]
    languageId=[integer]'
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```{
  "status": 200,
  "message": "Accepted, Ok",
  "model": [
    {
      "akhza": [
        {
          "id": 2575,
          "name": "اخزا 601",
          "YTM": 29.99
        },
        {
          "id": 3496,
          "name": "اخزا 609",
          "YTM": 28.54
        },
        {
          "id": 4285,
          "name": "اخزا 605",
          "YTM": 28.38
        }
      ]
    },
    {
      "owragh": [
        {
          "id": 4281,
          "name": "صبا 1401",
          "YTM": 172.94
        },
        {
          "id": 9325,
          "name": "اشاد9",
          "YTM": 28.06
        },
        {
          "id": 6489,
          "name": "کرمان98",
          "YTM": 26.13
        }
      ]
    },
    {
      "repos": [
        {
          "id": 641,
          "name": "پشتوانه طلای لوتوس ETM",
          "last_month_prof": 10.79
        },
        {
          "id": 9325,
          "name": "اوراق بهادار مبتنی بر سکه طلای کیان",
          "last_month_prof": 8.81
        },
        {
          "id": 64,
          "name": "زرافشان امید ایرانیان",
          "last_month_prof": 7.86
        }
      ]
    }
  ]
}
```
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ error : "YOUR DESIRED MESSAGE(preferred persian)" }`

  OR

  * **Code:** 401 UNAUTHORIZED <br />
    **Content:** `{ error : "YOUR DESIRED MESSAGE(preferred persian)" }`

  OR
    *    **...**
