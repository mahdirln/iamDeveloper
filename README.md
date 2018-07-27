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
*   **Required:**<br/>
    id=[integer]<br/>
    languageId=[integer]
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```{
    "status": 200,
    "message": "Ok, successfull",
    "model": {
        "id": 1,
        "first_name": "John",
        "last_name": "Smith",
        "email": "mahdi.r.ln@gmail.com",
        "company_enabled": true,
        "company_required": false,
        "company": "Nop Solutions Ltd",
        "country_enabled": true,
        "country_id": 1,
        "country_name": "United States",
        "state_province_enabled": true,
        "state_province_id": 40,
        "state_province_name": "New York",
        "city_enabled": true,
        "city_required": true,
        "city": "New York",
        "street_address_enabled": true,
        "street_address_required": true,
        "address1": "21 West 52nd Street",
        "street_address2_enabled": true,
        "street_address2_required": false,
        "address2": "",
        "zip_postal_code_enabled": true,
        "zip_postal_code_required": true,
        "zip_postal_code": "10021",
        "phone_enabled": true,
        "phone_required": true,
        "phone_number": "12345678",
        "fax_enabled": true,
        "fax_required": false,
        "fax_number": "",
        "formatted_custom_address_attributes": "",
        "custom_address_attributes": [],
        "CustomProperties": {}
    }
}
```
 
* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
  **Content:** 
  ```{
        "status": 400,
        "message": "Bad request, address id should not be zero",
        "model": null
  ```}


  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** 
  ```{
        "status": 404,
        "message": "Not found, address is not found",
        "model": null
  ```}
  
