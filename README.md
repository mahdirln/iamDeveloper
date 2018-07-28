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
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, address id should not be zero",
    "model": null
  }
  `

  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, address is not found",
    "model": null
  }
  `
  ----
* **URL**
  /address/GetByCurrentCustomer

* **Method:**
    `GET`
*  **URL Params** 
    `NONE`
*   **Required:** 
    `NONE`
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

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
  
**Catalog**
----
* **URL**
  /catalog/PopularProductTags

* **Method:**
    `GET`
*  **URL Params**<br/>
   `languageId=[integer]`
    *language id*<br/>
   `storeId=[integer]`
    *store id*<br/>
*   **Required:**<br/>
    languageId=[integer]
    storeId=[integer]<br/>
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": {
        "TotalTags": 16,
        "Tags": [
            {
                "id": 4,
                "name": "apparel",
                "se_name": "apparel",
                "product_count": 9
            },
            {
                "id": 8,
                "name": "awesome",
                "se_name": "awesome",
                "product_count": 17
            },
            {
                "id": 1,
                "name": "nice",
                "se_name": "nice",
                "product_count": 4
            }
        ]
    }
}
```
----
* **URL**
  /catalog/categoryProducts

* **Method:**
    `GET`
*  **URL Params**<br/>
   `languageId=[integer]`
    *language id*<br/>
*   **Required:**<br/>
    languageId=[integer]<br/>
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": [
        {
            "category_model": {
                "id": 2,
                "name": "Desktops",
                "descriprion": null,
                "meta_keywords": null,
                "meta_description": null,
                "meta_title": null,
                "se_name": "desktops",
                "parent_category_id": 1,
                "picture_id": 2,
                "picture": {
                    "id": 2,
                    "image_base64": null,
                    "image_url": "http://localhost/content/images/thumbs/0000002_desktops_450.jpg",
                    "thumb_image_url": null,
                    "seo_filename": null,
                    "mime_type": null,
                    "full_size_image_url": "http://localhost/content/images/thumbs/0000002_desktops.jpg",
                    "title": "نمایش محصولات در دسته  Desktops",
                    "alternate_text": "تصویر برای دسته  Desktops"
                }
            },
            "product_details_list_model": [
                {
                    "default_picture_model": {
                        "id": 20,
                        "image_base64": null,
                        "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
                        "thumb_image_url": null,
                        "seo_filename": null,
                        "mime_type": null,
                        "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
                        "title": "تصویر  Build your own computer",
                        "alternate_text": "تصویر  Build your own computer"
                    },
                    "product_price": {
                        "currency_code": "RLS",
                        "old_price": null,
                        "price": "ريال44,916/00",
                        "price_with_discount": null,
                        "price_value": 44916,
                        "customer_enters_price": false,
                        "call_for_price": false,
                        "product_id": 1,
                        "hide_prices": false,
                        "is_rental": false,
                        "rental_price": null,
                        "display_tax_shipping_info": false,
                        "base_price_pangv": null,
                        "CustomProperties": {}
                    },
                    "name": "Build your own computer",
                    "short_description": "Build it",
                    "full_description": "<p>Fight back against cluttered workspaces with the stylish IBM zBC12 All-in-One desktop PC, featuring powerful computing resources and a stunning 20.1-inch widescreen display with stunning XBRITE-HiColor LCD technology. The black IBM zBC12 has a built-in microphone and MOTION EYE camera with face-tracking technology that allows for easy communication with friends and family. And it has a built-in DVD burner and Sony's Movie Store software so you can create a digital entertainment library for personal viewing at your convenience. Easy to setup and even easier to use, this JS-series All-in-One includes an elegantly designed keyboard and a USB mouse.</p>",
                    "meta_keywords": null,
                    "meta_description": null,
                    "meta_title": null,
                    "se_name": "build-your-own-computer",
                    "Id": 1,
                    "CustomProperties": {}
                },
                {
                    "default_picture_model": {
                        "id": 22,
                        "image_base64": null,
                        "image_url": "http://localhost/content/images/thumbs/0000022_digital-storm-vanquish-3-custom-performance-pc_550.jpeg",
                        "thumb_image_url": null,
                        "seo_filename": null,
                        "mime_type": null,
                        "full_size_image_url": "http://localhost/content/images/thumbs/0000022_digital-storm-vanquish-3-custom-performance-pc.jpeg",
                        "title": "تصویر  Digital Storm VANQUISH 3 Custom Performance PC",
                        "alternate_text": "تصویر  Digital Storm VANQUISH 3 Custom Performance PC"
                    },
                    "product_price": {
                        "currency_code": "RLS",
                        "old_price": null,
                        "price": "ريال47,124/37",
                        "price_with_discount": null,
                        "price_value": 47124.37,
                        "customer_enters_price": false,
                        "call_for_price": false,
                        "product_id": 2,
                        "hide_prices": false,
                        "is_rental": false,
                        "rental_price": null,
                        "display_tax_shipping_info": false,
                        "base_price_pangv": null,
                        "CustomProperties": {}
                    },
                    "name": "Digital Storm VANQUISH 3 Custom Performance PC",
                    "short_description": "Digital Storm Vanquish 3 Desktop PC",
                    "full_description": "<p>Blow the doors off today’s most demanding games with maximum detail, speed, and power for an immersive gaming experience without breaking the bank.</p><p>Stay ahead of the competition, VANQUISH 3 is fully equipped to easily handle future upgrades, keeping your system on the cutting edge for years to come.</p><p>Each system is put through an extensive stress test, ensuring you experience zero bottlenecks and get the maximum performance from your hardware.</p>",
                    "meta_keywords": null,
                    "meta_description": null,
                    "meta_title": null,
                    "se_name": "digital-storm-vanquish-3-custom-performance-pc",
                    "Id": 2,
                    "CustomProperties": {}
                },
                {
                    "default_picture_model": {
                        "id": 23,
                        "image_base64": null,
                        "image_url": "http://localhost/content/images/thumbs/0000023_lenovo-ideacentre-600-all-in-one-pc_550.jpeg",
                        "thumb_image_url": null,
                        "seo_filename": null,
                        "mime_type": null,
                        "full_size_image_url": "http://localhost/content/images/thumbs/0000023_lenovo-ideacentre-600-all-in-one-                                    pc.jpeg",
                        "title": "تصویر  Lenovo IdeaCentre 600 All-in-One PC",
                        "alternate_text": "تصویر  Lenovo IdeaCentre 600 All-in-One PC"
                    },
                    "product_price": {
                        "currency_code": "RLS",
                        "old_price": null,
                        "price": "ريال18,715/00",
                        "price_with_discount": null,
                        "price_value": 18715,
                        "customer_enters_price": false,
                        "call_for_price": false,
                        "product_id": 3,
                        "hide_prices": false,
                        "is_rental": false,
                        "rental_price": null,
                        "display_tax_shipping_info": false,
                        "base_price_pangv": null,
                        "CustomProperties": {}
                    },
                    "name": "Lenovo IdeaCentre 600 All-in-One PC",
                    "short_description": "",
                    "full_description": "<p>The A600 features a 21.5in screen, DVD or optional Blu-Ray drive, support for the full beans 1920 x 1080 HD, Dolby Home Cinema certification and an optional hybrid analogue/digital TV tuner.</p><p>Connectivity is handled by 802.11a/b/g - 802.11n is optional - and an ethernet port. You also get four USB ports, a Firewire slot, a six-in-one card reader and a 1.3- or two-megapixel webcam.</p>",
                    "meta_keywords": null,
                    "meta_description": null,
                    "meta_title": null,
                    "se_name": "lenovo-ideacentre-600-all-in-one-pc",
                    "Id": 3,
                    "CustomProperties": {}
        }
    ]
}
```

**Category**
----
* **URL**
  /category/getById

* **Method:**
    `GET`
*  **URL Params**<br/>
   `id=[integer]`
    *id*<br/>
   `languageId=[integer]`
    *language id*<br/>
   `storeId=[integer]`
    *store id*<br/>
*   **Required:**<br/>
    id=[integer]
    storeId=[integer]<br/>
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": {
        "id": 1,
        "name": "Computers",
        "descriprion": null,
        "meta_keywords": null,
        "meta_description": null,
        "meta_title": null,
        "se_name": "computers",
        "parent_category_id": 0,
        "picture_id": 1,
        "picture": {
            "id": 1,
            "image_base64": null,
            "image_url": "http://nop-extensions.ir/content/images/thumbs/0000001_computers_450.jpeg",
            "thumb_image_url": null,
            "seo_filename": null,
            "mime_type": null,
            "full_size_image_url": "http://nop-extensions.ir/content/images/thumbs/0000001_computers.jpeg",
            "title": "نمایش محصولات در دسته  Computers",
            "alternate_text": "تصویر برای دسته  Computers"
        }
    }
}
```
----
* **URL**
  /category/GetCategoryByParentId

* **Method:**
    `GET`
*  **URL Params**<br/>
   `parentCategoryId=[integer]`
    *parent category id*<br/>
   `storeId=[integer]`
    *store id*<br/>
   `languageId=[integer]`
    *language id*<br/>
*   **Required:**<br/>
    parentCategoryId=[integer]
    storeId=[integer]
    languageId=[integer]<br/>
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": [
        {
            "id": 2,
            "name": "Desktops",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "desktops",
            "parent_category_id": 1,
            "picture_id": 2,
            "picture": {
                "id": 2,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000002_desktops_450.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000002_desktops.jpg",
                "title": "نمایش محصولات در دسته  Desktops",
                "alternate_text": "تصویر برای دسته  Desktops"
            }
        },
        {
            "id": 3,
            "name": "Notebooks",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "notebooks",
            "parent_category_id": 1,
            "picture_id": 3,
            "picture": {
                "id": 3,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000003_notebooks_450.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000003_notebooks.jpg",
                "title": "نمایش محصولات در دسته  Notebooks",
                "alternate_text": "تصویر برای دسته  Notebooks"
            }
        },
        {
            "id": 4,
            "name": "Software",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "software",
            "parent_category_id": 1,
            "picture_id": 4,
            "picture": {
                "id": 4,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000004_software_450.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000004_software.jpg",
                "title": "نمایش محصولات در دسته  Software",
                "alternate_text": "تصویر برای دسته  Software"
            }
        }
    ]
}
```
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
----
* **URL**
  /category/GetDisplayOnHomePageCategories

* **Method:**
    `GET`
*  **URL Params**<br/>
   `storeId=[integer]`
    *store id*<br/>
   `languageId=[integer]`
    *language id*<br/>
*   **Required:**<br/>
    storeId=[integer]
    languageId=[integer]<br/>
* **Data Params**
    `NONE`
* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": [
        {
            "id": 5,
            "name": "Electronics",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "electronics",
            "parent_category_id": 0,
            "picture_id": 0,
            "picture": {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000005_electronics_450.jpeg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000005_electronics.jpeg",
                "title": "نمایش محصولات در دسته  Electronics",
                "alternate_text": "تصویر برای دسته  Electronics"
            }
        },
        {
            "id": 9,
            "name": "Apparel",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "apparel",
            "parent_category_id": 0,
            "picture_id": 0,
            "picture": {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000009_apparel_450.jpeg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000009_apparel.jpeg",
                "title": "نمایش محصولات در دسته  Apparel",
                "alternate_text": "تصویر برای دسته  Apparel"
            }
        },
        {
            "id": 13,
            "name": "Digital downloads",
            "descriprion": null,
            "meta_keywords": null,
            "meta_description": null,
            "meta_title": null,
            "se_name": "digital-downloads",
            "parent_category_id": 0,
            "picture_id": 0,
            "picture": {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000013_digital-downloads_450.jpeg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000013_digital-downloads.jpeg",
                "title": "نمایش محصولات در دسته  Digital downloads",
                "alternate_text": "تصویر برای دسته  Digital downloads"
            }
        }
    ]
}
```
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
