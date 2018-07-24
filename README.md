**Over View  feeds**
----
  Returns the most profitable feeds in each category
  A categorized list of the most interesting items.(overall Info's).

* **URL**
  /feeds/overview

* **Method:**
    `GET`
*  **URL Params**
   `numberOfFeeds=[integer]`
    *specify the number of top feeds to return*<br/>
    `3` means it should only return three highest valuable feeds from each category
*   **Required:**
    `numberOfFeeds=[integer]`
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
    
**"Owragh" feeds**
----
  Returns json data about Owragh.
  A list of all Owragh including "akhza"(اسناد خزانه), that is available(overall Info's).

* **URL**
  /feeds/owragh

* **Method:**
    `GET`
*  **URL Params**
    `is_asnad=[boolean]`
    *specify if the result should only contain "akhza" or not.*<br/>
    `TRUE` only akhza not other owragh(اسناد خزانه)<br/>
    `FALSE` only other owragh not akhza(اسناد خزانه)

*   **Required:**
    `is_asnad=[boolean]`
* **Data Params**
    `NONE`

* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
  "status": 200,
  "message": "Accepted, Ok",
  "model": [
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
    ...
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

**"Owragh" details**
----
  Returns json data about detail of "owragh" whether it's "akhza" or not.
  it should contain every detail of owragh, in a dynamic way.

* **URL**
  /feeds/owragh_detail

* **Method:**
    `GET`
*  **URL Params**
    `id=[integer]`
    *specify the desired  owragh to get the detail*
*   **Required:**
    `id=[integer]`
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
      "price_board": {
        "last_price": {
          "price": 58720,
          "change": -704,
          "change_precentage": -0.12
        },
        "final_price": {
          "price": 587037,
          "change": -687,
          "change_precentage": -0.12
        },
        "expire": {
          "date": "1399/06/25",
          "days_left": 792
        }
      }
    },
    {
      "buy_sell_table": {
        "buys": [
          {
            "count": 1,
            "YTM": 26.74,
            "price": 598000,
            "volume": 200
          },
          {
            "count": 1,
            "YTM": 26.64,
            "price": 599000,
            "volume": 79
          },
          {
            "count": 2,
            "YTM": 26.57,
            "price": 599750,
            "volume": 1280
          }
        ],
        "sells": [
          {
            "count": 1,
            "YTM": 27.83,
            "price": 587000,
            "volume": 131
          },
          {
            "count": 1,
            "YTM": 28.02,
            "price": 585101,
            "volume": 3000
          },
          {
            "count": 1,
            "YTM": 28.02,
            "price": 585100,
            "volume": 5000
          }
        ]
      }
    },
    {
      "namad_properties": {
        "نام اوراق": "اسناد خزانه اسلامی971228",
        "نام لاتین": "Treasury Bill19031",
        "کد ISIN": "IRB3BT0797C1",
        "نمونیک": "BT071",
        "نماد معاملاتی": "سخاب7",
        "بازار": "اوراق با درآمد ثابت",
        "گروه صنعت": "اوراق تامین مالی",
        "زیر گروه صنعت": "اسناد خزانه اسلامی"
      }
    },
    {
      "namd_info": {
        "نام اوراق": "اسناد خزانه اسلامی971228",
        "(مبلغ اسمی هر ورقه (ریال": "1,000,000",
        "(مبلغ کل اوراق(میلیون ریال": "35,000,000",
        "(مبلغ پذیرش شده(میلیون ریال": "35,000,000",
        "تاریخ انتشار": "1395/12/28",
        "(مدت اوراق(ماه": "24",
        "نوع اوراق": "اسناد خزانه",
        "تعداد کل اوراق": "35,000,000",
        "تعداد اوراق پذیرش شده": "35,000,000",
        "تاریخ سررسید": "1397/12/28"
      }
    },
    {
      "arkan": {
        "ناشر": "وزارت امور اقتصادي و دارايي",
        "ضامن": "خزانه داري كل كشور",
        "عامل پرداخت سود": "شركت سپرده گذاري مركزي اوراق بهادار و تسويه وجوه (سهامي عام)"
      }
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
    
**YTM history**
----
  Returns YTM history of each owragh, for plotting

* **URL**
  /feeds/get_ytm_hitory

* **Method:**
    `GET`
*  **URL Params**
    `id=[integer]`
    *specify the desired  owragh to get the history*
*   **Required:**
    `id=[integer]`
* **Data Params**
    `NONE`

* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```{
  "status": 200,
  "message": "Accepted, Ok",
  "days": [
    [
      1512851400000, #this is the time stamp of the day
      0.17041 #YTM value on the particular day
    ],
    [
      1512937800000,
      0.17228
    ],
    [
      1513024200000,
      0.17188
    ],
    [
      1513110600000,
      0.16766
    ]
  ]
  ...
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
