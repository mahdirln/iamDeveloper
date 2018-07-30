**Address**
----
* **URL**
  /address/getById

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
----
* **URL**
  /category/search

* **Method:**
    `POST`
*  **URL Params**<br/>
    `NONE`  
*   **Required:**<br/>
    `NONE`
* **Data Params**
   `category_name=[string]`
    *category name*<br/>
   `store_id=[integer]`
    *store id*<br/>
    `language_id=[integer]`
    *language id*<br/>
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
**MANUFACTURER**
----
* **URL**
  /manufacturer/manufacturers

* **Method:**
    `GET`
*  **URL Params**<br/>
   `storeId=[integer]`
    *store id*<br/>
   `languageId=[integer]`
    *language id*<br/>
   `count=[integer]`
    *count*<br/>
*   **Required:**<br/>
    storeId=[integer]<br/>
    languageId=[integer]
    count=[integer]
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
            "Id": 1,
            "name": "Apple",
            "description": null,
            "picture_id": 17,
            "picture_model": {
                "id": 17,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000017_apple_420.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000017_apple.jpg",
                "title": "Apple",
                "alternate_text": "Apple"
            },
            "published": true,
            "deleted": false,
            "display_order": 1
        },
        {
            "Id": 2,
            "name": "HP",
            "description": null,
            "picture_id": 18,
            "picture_model": {
                "id": 18,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000018_hp_420.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000018_hp.jpg",
                "title": "HP",
                "alternate_text": "HP"
            },
            "published": true,
            "deleted": false,
            "display_order": 5
        },
        {
            "Id": 3,
            "name": "Nike",
            "description": null,
            "picture_id": 19,
            "picture_model": {
                "id": 19,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000019_nike_420.jpg",
                "thumb_image_url": null,
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000019_nike.jpg",
                "title": "Nike",
                "alternate_text": "Nike"
            },
            "published": true,
            "deleted": false,
            "display_order": 5
        }
    ]
}
```
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 400,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
**PRODUCT**
----
* **URL**
  /product/getById

* **Method:**
    `GET`
*  **URL Params**<br/>
   `id=[integer]`
    *id*<br/>
   `storeId=[integer]`
    *store id*<br/>
*   **Required:**<br/>
    Id=[integer]<br/>
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
        "default_picture_zoom_enabled": false,
        "default_picture_model": {
            "id": 0,
            "image_base64": null,
            "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
            "thumb_image_url": null,
            "seo_filename": null,
            "mime_type": null,
            "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
            "title": "تصویر  Build your own computer",
            "alternate_text": "تصویر  Build your own computer"
        },
        "pictures_model": [
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            },
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            }
        ],
        "name": "Build your own computer",
        "short_description": "Build it",
        "full_description": "<p>Fight back against cluttered workspaces with the stylish IBM zBC12 All-in-One desktop PC, featuring powerful computing resources and a stunning 20.1-inch widescreen display with stunning XBRITE-HiColor LCD technology. The black IBM zBC12 has a built-in microphone and MOTION EYE camera with face-tracking technology that allows for easy communication with friends and family. And it has a built-in DVD burner and Sony's Movie Store software so you can create a digital entertainment library for personal viewing at your convenience. Easy to setup and even easier to use, this JS-series All-in-One includes an elegantly designed keyboard and a USB mouse.</p>",
        "meta_keywords": null,
        "meta_description": "Build it",
        "meta_title": null,
        "se_name": "build-your-own-computer",
        "product_type": 5,
        "show_sku": true,
        "sku": "COMP_CUST",
        "show_manufacturer_part_number": false,
        "manufacturer_part_number": null,
        "show_gtin": false,
        "gtin": null,
        "show_vendor": false,
        "vendor_model": {
            "Name": null,
            "SeName": null,
            "Id": 0,
            "CustomProperties": {}
        },
        "has_sample_download": false,
        "gift_cart": {
            "is_gift_card": false,
            "recipient_name": null,
            "recipient_email": null,
            "sender_name": null,
            "sender_email": null,
            "message": null,
            "gift_cart_type": 0,
            "CustomProperties": {}
        },
        "is_ship_enable": true,
        "is_free_shipping": true,
        "free_shipping_notification_enabled": true,
        "delivery_date": null,
        "is_rental": false,
        "rental_start_date": null,
        "rental_end_date": null,
        "manage_inventory_method": 1,
        "stock_availability": "در انبار",
        "display_back_in_stock_subscription": false,
        "email_a_friend_enabled": true,
        "compare_products_enabled": true,
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
        "add_to_cart": {
            "product_id": 1,
            "entered_quantity": 1,
            "minimum_quantity_notification": null,
            "allowed_quantities": [],
            "customer_enters_price": false,
            "customer_Entered_price": 0,
            "customer_entered_price_range": null,
            "disable_buy_button": false,
            "disable_wishlist_button": false,
            "is_rental": false,
            "available_for_pre_order": false,
            "pre_order_availability_start_date_time_utc": null,
            "updated_shopping_cart_item_id": 0,
            "update_shopping_cart_item_type": null,
            "CustomProperties": {}
        },
        "bread_crump": {
            "enable": true,
            "product_id": 1,
            "product_name": "Build your own computer",
            "product_se_name": "build-your-own-computer",
            "category_breadcrumb": [
                {
                    "Name": "Computers",
                    "SeName": "computers",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 1,
                    "CustomProperties": {}
                },
                {
                    "Name": "Desktops",
                    "SeName": "desktops",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 2,
                    "CustomProperties": {}
                }
            ],
            "CustomProperties": {}
        },
        "product_tags": [
            {
                "id": 6,
                "name": "computer",
                "se_name": "computer",
                "product_count": 14
            },
            {
                "id": 8,
                "name": "awesome",
                "se_name": "awesome",
                "product_count": 17
            }
        ],
        "product_attributes": [
            {
                "product_id": 1,
                "product_attribute_id": 6,
                "name": "Processor",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2.2 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 1,
                        "CustomProperties": {}
                    },
                    {
                        "name": "2.5 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال561/45",
                        "price_adjustment_value": 561.45,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 2,
                        "CustomProperties": {}
                    }
                ],
                "Id": 1,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 7,
                "name": "RAM",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 3,
                        "CustomProperties": {}
                    },
                    {
                        "name": "4GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال748/60",
                        "price_adjustment_value": 748.6,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 4,
                        "CustomProperties": {}
                    },
                    {
                        "name": "8GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 5,
                        "CustomProperties": {}
                    }
                ],
                "Id": 2,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 4,
                "name": "HDD",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "320 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 6,
                        "CustomProperties": {}
                    },
                    {
                        "name": "400 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال3,743/00",
                        "price_adjustment_value": 3743,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 7,
                        "CustomProperties": {}
                    }
                ],
                "Id": 3,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 5,
                "name": "OS",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "Vista Home",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 8,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Vista Premium",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 9,
                        "CustomProperties": {}
                    }
                ],
                "Id": 4,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 9,
                "name": "Software",
                "description": null,
                "text_prompt": null,
                "is_required": false,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 3,
                "values": [
                    {
                        "name": "Microsoft Office",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 10,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Acrobat Reader",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال374/30",
                        "price_adjustment_value": 374.3,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 11,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Total Commander",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال187/15",
                        "price_adjustment_value": 187.15,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 12,
                        "CustomProperties": {}
                    }
                ],
                "Id": 5,
                "CustomProperties": {}
            }
        ],
        "product_specifications": [],
        "product_manufacturers": [],
        "product_review_overview": {
            "ProductId": 1,
            "RatingSum": 0,
            "TotalReviews": 0,
            "AllowCustomerReviews": true,
            "CustomProperties": {}
        },
        "tier_prices": [],
        "associated_products": [],
        "display_discontinued_message": false,
        "current_store_name": "Your store name",
        "Id": 1,
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
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, product id should not be zero",
    "model": null
  }
  `
  
  OR 
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, product is not found",
    "model": null
  }
  `
  ----
* **URL**
  /product/getByStoreId

* **Method:**
    `GET`
*  **URL Params**<br/>
   `storeId=[integer]`
    *store id*<br/>
*   **Required:**<br/>
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
        [
        "default_picture_zoom_enabled": false,
        "default_picture_model": {
            "id": 0,
            "image_base64": null,
            "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
            "thumb_image_url": null,
            "seo_filename": null,
            "mime_type": null,
            "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
            "title": "تصویر  Build your own computer",
            "alternate_text": "تصویر  Build your own computer"
        },
        "pictures_model": [
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            },
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            }
        ],
        "name": "Build your own computer",
        "short_description": "Build it",
        "full_description": "<p>Fight back against cluttered workspaces with the stylish IBM zBC12 All-in-One desktop PC, featuring powerful computing resources and a stunning 20.1-inch widescreen display with stunning XBRITE-HiColor LCD technology. The black IBM zBC12 has a built-in microphone and MOTION EYE camera with face-tracking technology that allows for easy communication with friends and family. And it has a built-in DVD burner and Sony's Movie Store software so you can create a digital entertainment library for personal viewing at your convenience. Easy to setup and even easier to use, this JS-series All-in-One includes an elegantly designed keyboard and a USB mouse.</p>",
        "meta_keywords": null,
        "meta_description": "Build it",
        "meta_title": null,
        "se_name": "build-your-own-computer",
        "product_type": 5,
        "show_sku": true,
        "sku": "COMP_CUST",
        "show_manufacturer_part_number": false,
        "manufacturer_part_number": null,
        "show_gtin": false,
        "gtin": null,
        "show_vendor": false,
        "vendor_model": {
            "Name": null,
            "SeName": null,
            "Id": 0,
            "CustomProperties": {}
        },
        "has_sample_download": false,
        "gift_cart": {
            "is_gift_card": false,
            "recipient_name": null,
            "recipient_email": null,
            "sender_name": null,
            "sender_email": null,
            "message": null,
            "gift_cart_type": 0,
            "CustomProperties": {}
        },
        "is_ship_enable": true,
        "is_free_shipping": true,
        "free_shipping_notification_enabled": true,
        "delivery_date": null,
        "is_rental": false,
        "rental_start_date": null,
        "rental_end_date": null,
        "manage_inventory_method": 1,
        "stock_availability": "در انبار",
        "display_back_in_stock_subscription": false,
        "email_a_friend_enabled": true,
        "compare_products_enabled": true,
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
        "add_to_cart": {
            "product_id": 1,
            "entered_quantity": 1,
            "minimum_quantity_notification": null,
            "allowed_quantities": [],
            "customer_enters_price": false,
            "customer_Entered_price": 0,
            "customer_entered_price_range": null,
            "disable_buy_button": false,
            "disable_wishlist_button": false,
            "is_rental": false,
            "available_for_pre_order": false,
            "pre_order_availability_start_date_time_utc": null,
            "updated_shopping_cart_item_id": 0,
            "update_shopping_cart_item_type": null,
            "CustomProperties": {}
        },
        "bread_crump": {
            "enable": true,
            "product_id": 1,
            "product_name": "Build your own computer",
            "product_se_name": "build-your-own-computer",
            "category_breadcrumb": [
                {
                    "Name": "Computers",
                    "SeName": "computers",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 1,
                    "CustomProperties": {}
                },
                {
                    "Name": "Desktops",
                    "SeName": "desktops",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 2,
                    "CustomProperties": {}
                }
            ],
            "CustomProperties": {}
        },
        "product_tags": [
            {
                "id": 6,
                "name": "computer",
                "se_name": "computer",
                "product_count": 14
            },
            {
                "id": 8,
                "name": "awesome",
                "se_name": "awesome",
                "product_count": 17
            }
        ],
        "product_attributes": [
            {
                "product_id": 1,
                "product_attribute_id": 6,
                "name": "Processor",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2.2 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 1,
                        "CustomProperties": {}
                    },
                    {
                        "name": "2.5 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال561/45",
                        "price_adjustment_value": 561.45,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 2,
                        "CustomProperties": {}
                    }
                ],
                "Id": 1,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 7,
                "name": "RAM",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 3,
                        "CustomProperties": {}
                    },
                    {
                        "name": "4GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال748/60",
                        "price_adjustment_value": 748.6,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 4,
                        "CustomProperties": {}
                    },
                    {
                        "name": "8GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 5,
                        "CustomProperties": {}
                    }
                ],
                "Id": 2,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 4,
                "name": "HDD",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "320 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 6,
                        "CustomProperties": {}
                    },
                    {
                        "name": "400 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال3,743/00",
                        "price_adjustment_value": 3743,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 7,
                        "CustomProperties": {}
                    }
                ],
                "Id": 3,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 5,
                "name": "OS",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "Vista Home",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 8,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Vista Premium",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 9,
                        "CustomProperties": {}
                    }
                ],
                "Id": 4,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 9,
                "name": "Software",
                "description": null,
                "text_prompt": null,
                "is_required": false,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 3,
                "values": [
                    {
                        "name": "Microsoft Office",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 10,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Acrobat Reader",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال374/30",
                        "price_adjustment_value": 374.3,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 11,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Total Commander",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال187/15",
                        "price_adjustment_value": 187.15,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 12,
                        "CustomProperties": {}
                    }
                ],
                "Id": 5,
                "CustomProperties": {}
            }
        ],
        "product_specifications": [],
        "product_manufacturers": [],
        "product_review_overview": {
            "ProductId": 1,
            "RatingSum": 0,
            "TotalReviews": 0,
            "AllowCustomerReviews": true,
            "CustomProperties": {}
        },
        "tier_prices": [],
        "associated_products": [],
        "display_discontinued_message": false,
        "current_store_name": "Your store name",
        "Id": 1,
        "CustomProperties": {}
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
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, store id should not be zero",
    "model": null
  }
  `
----
* **URL**
/product/getFeatureProducts

* **Method:**
    `GET`
*  **URL Params**<br/>
   `storeId=[integer]`
    *store id*<br/>
*   **Required:**<br/>
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
        [
        "default_picture_zoom_enabled": false,
        "default_picture_model": {
            "id": 0,
            "image_base64": null,
            "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
            "thumb_image_url": null,
            "seo_filename": null,
            "mime_type": null,
            "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
            "title": "تصویر  Build your own computer",
            "alternate_text": "تصویر  Build your own computer"
        },
        "pictures_model": [
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            },
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            }
        ],
        "name": "Build your own computer",
        "short_description": "Build it",
        "full_description": "<p>Fight back against cluttered workspaces with the stylish IBM zBC12 All-in-One desktop PC, featuring powerful computing resources and a stunning 20.1-inch widescreen display with stunning XBRITE-HiColor LCD technology. The black IBM zBC12 has a built-in microphone and MOTION EYE camera with face-tracking technology that allows for easy communication with friends and family. And it has a built-in DVD burner and Sony's Movie Store software so you can create a digital entertainment library for personal viewing at your convenience. Easy to setup and even easier to use, this JS-series All-in-One includes an elegantly designed keyboard and a USB mouse.</p>",
        "meta_keywords": null,
        "meta_description": "Build it",
        "meta_title": null,
        "se_name": "build-your-own-computer",
        "product_type": 5,
        "show_sku": true,
        "sku": "COMP_CUST",
        "show_manufacturer_part_number": false,
        "manufacturer_part_number": null,
        "show_gtin": false,
        "gtin": null,
        "show_vendor": false,
        "vendor_model": {
            "Name": null,
            "SeName": null,
            "Id": 0,
            "CustomProperties": {}
        },
        "has_sample_download": false,
        "gift_cart": {
            "is_gift_card": false,
            "recipient_name": null,
            "recipient_email": null,
            "sender_name": null,
            "sender_email": null,
            "message": null,
            "gift_cart_type": 0,
            "CustomProperties": {}
        },
        "is_ship_enable": true,
        "is_free_shipping": true,
        "free_shipping_notification_enabled": true,
        "delivery_date": null,
        "is_rental": false,
        "rental_start_date": null,
        "rental_end_date": null,
        "manage_inventory_method": 1,
        "stock_availability": "در انبار",
        "display_back_in_stock_subscription": false,
        "email_a_friend_enabled": true,
        "compare_products_enabled": true,
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
        "add_to_cart": {
            "product_id": 1,
            "entered_quantity": 1,
            "minimum_quantity_notification": null,
            "allowed_quantities": [],
            "customer_enters_price": false,
            "customer_Entered_price": 0,
            "customer_entered_price_range": null,
            "disable_buy_button": false,
            "disable_wishlist_button": false,
            "is_rental": false,
            "available_for_pre_order": false,
            "pre_order_availability_start_date_time_utc": null,
            "updated_shopping_cart_item_id": 0,
            "update_shopping_cart_item_type": null,
            "CustomProperties": {}
        },
        "bread_crump": {
            "enable": true,
            "product_id": 1,
            "product_name": "Build your own computer",
            "product_se_name": "build-your-own-computer",
            "category_breadcrumb": [
                {
                    "Name": "Computers",
                    "SeName": "computers",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 1,
                    "CustomProperties": {}
                },
                {
                    "Name": "Desktops",
                    "SeName": "desktops",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 2,
                    "CustomProperties": {}
                }
            ],
            "CustomProperties": {}
        },
        "product_tags": [
            {
                "id": 6,
                "name": "computer",
                "se_name": "computer",
                "product_count": 14
            },
            {
                "id": 8,
                "name": "awesome",
                "se_name": "awesome",
                "product_count": 17
            }
        ],
        "product_attributes": [
            {
                "product_id": 1,
                "product_attribute_id": 6,
                "name": "Processor",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2.2 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 1,
                        "CustomProperties": {}
                    },
                    {
                        "name": "2.5 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال561/45",
                        "price_adjustment_value": 561.45,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 2,
                        "CustomProperties": {}
                    }
                ],
                "Id": 1,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 7,
                "name": "RAM",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 3,
                        "CustomProperties": {}
                    },
                    {
                        "name": "4GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال748/60",
                        "price_adjustment_value": 748.6,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 4,
                        "CustomProperties": {}
                    },
                    {
                        "name": "8GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 5,
                        "CustomProperties": {}
                    }
                ],
                "Id": 2,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 4,
                "name": "HDD",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "320 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 6,
                        "CustomProperties": {}
                    },
                    {
                        "name": "400 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال3,743/00",
                        "price_adjustment_value": 3743,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 7,
                        "CustomProperties": {}
                    }
                ],
                "Id": 3,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 5,
                "name": "OS",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "Vista Home",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 8,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Vista Premium",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 9,
                        "CustomProperties": {}
                    }
                ],
                "Id": 4,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 9,
                "name": "Software",
                "description": null,
                "text_prompt": null,
                "is_required": false,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 3,
                "values": [
                    {
                        "name": "Microsoft Office",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 10,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Acrobat Reader",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال374/30",
                        "price_adjustment_value": 374.3,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 11,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Total Commander",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال187/15",
                        "price_adjustment_value": 187.15,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 12,
                        "CustomProperties": {}
                    }
                ],
                "Id": 5,
                "CustomProperties": {}
            }
        ],
        "product_specifications": [],
        "product_manufacturers": [],
        "product_review_overview": {
            "ProductId": 1,
            "RatingSum": 0,
            "TotalReviews": 0,
            "AllowCustomerReviews": true,
            "CustomProperties": {}
        },
        "tier_prices": [],
        "associated_products": [],
        "display_discontinued_message": false,
        "current_store_name": "Your store name",
        "Id": 1,
        "CustomProperties": {}
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
/product/search

* **Method:**
    `GET`
*  **URL Params**<br/>
    `NONE`
*   **Required:**<br/>
    `NONE`
* **Data Params**
    id=[integer]
    *id*<br/>
    name=[string]
    *name*<br/>
    store_id=[integer]
    *store id*<br/>
    category_ids=list [integer]
    *category ids*<br/>
    language_id=[integer]
    *language id*<br/>

* **Success Response:**

  * **Code:** 200 <br/>
    **Content:** 
```
{
    "status": 200,
    "message": "Ok, successfull",
    "model": {
        [
        "default_picture_zoom_enabled": false,
        "default_picture_model": {
            "id": 0,
            "image_base64": null,
            "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
            "thumb_image_url": null,
            "seo_filename": null,
            "mime_type": null,
            "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
            "title": "تصویر  Build your own computer",
            "alternate_text": "تصویر  Build your own computer"
        },
        "pictures_model": [
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            },
            {
                "id": 0,
                "image_base64": null,
                "image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_550.jpeg",
                "thumb_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer_100.jpeg",
                "seo_filename": null,
                "mime_type": null,
                "full_size_image_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer.jpeg",
                "title": "تصویر  Build your own computer",
                "alternate_text": "تصویر  Build your own computer"
            }
        ],
        "name": "Build your own computer",
        "short_description": "Build it",
        "full_description": "<p>Fight back against cluttered workspaces with the stylish IBM zBC12 All-in-One desktop PC, featuring powerful computing resources and a stunning 20.1-inch widescreen display with stunning XBRITE-HiColor LCD technology. The black IBM zBC12 has a built-in microphone and MOTION EYE camera with face-tracking technology that allows for easy communication with friends and family. And it has a built-in DVD burner and Sony's Movie Store software so you can create a digital entertainment library for personal viewing at your convenience. Easy to setup and even easier to use, this JS-series All-in-One includes an elegantly designed keyboard and a USB mouse.</p>",
        "meta_keywords": null,
        "meta_description": "Build it",
        "meta_title": null,
        "se_name": "build-your-own-computer",
        "product_type": 5,
        "show_sku": true,
        "sku": "COMP_CUST",
        "show_manufacturer_part_number": false,
        "manufacturer_part_number": null,
        "show_gtin": false,
        "gtin": null,
        "show_vendor": false,
        "vendor_model": {
            "Name": null,
            "SeName": null,
            "Id": 0,
            "CustomProperties": {}
        },
        "has_sample_download": false,
        "gift_cart": {
            "is_gift_card": false,
            "recipient_name": null,
            "recipient_email": null,
            "sender_name": null,
            "sender_email": null,
            "message": null,
            "gift_cart_type": 0,
            "CustomProperties": {}
        },
        "is_ship_enable": true,
        "is_free_shipping": true,
        "free_shipping_notification_enabled": true,
        "delivery_date": null,
        "is_rental": false,
        "rental_start_date": null,
        "rental_end_date": null,
        "manage_inventory_method": 1,
        "stock_availability": "در انبار",
        "display_back_in_stock_subscription": false,
        "email_a_friend_enabled": true,
        "compare_products_enabled": true,
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
        "add_to_cart": {
            "product_id": 1,
            "entered_quantity": 1,
            "minimum_quantity_notification": null,
            "allowed_quantities": [],
            "customer_enters_price": false,
            "customer_Entered_price": 0,
            "customer_entered_price_range": null,
            "disable_buy_button": false,
            "disable_wishlist_button": false,
            "is_rental": false,
            "available_for_pre_order": false,
            "pre_order_availability_start_date_time_utc": null,
            "updated_shopping_cart_item_id": 0,
            "update_shopping_cart_item_type": null,
            "CustomProperties": {}
        },
        "bread_crump": {
            "enable": true,
            "product_id": 1,
            "product_name": "Build your own computer",
            "product_se_name": "build-your-own-computer",
            "category_breadcrumb": [
                {
                    "Name": "Computers",
                    "SeName": "computers",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 1,
                    "CustomProperties": {}
                },
                {
                    "Name": "Desktops",
                    "SeName": "desktops",
                    "NumberOfProducts": null,
                    "IncludeInTopMenu": true,
                    "SubCategories": [],
                    "Id": 2,
                    "CustomProperties": {}
                }
            ],
            "CustomProperties": {}
        },
        "product_tags": [
            {
                "id": 6,
                "name": "computer",
                "se_name": "computer",
                "product_count": 14
            },
            {
                "id": 8,
                "name": "awesome",
                "se_name": "awesome",
                "product_count": 17
            }
        ],
        "product_attributes": [
            {
                "product_id": 1,
                "product_attribute_id": 6,
                "name": "Processor",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2.2 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 1,
                        "CustomProperties": {}
                    },
                    {
                        "name": "2.5 GHz Intel Pentium Dual-Core E2200",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال561/45",
                        "price_adjustment_value": 561.45,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 2,
                        "CustomProperties": {}
                    }
                ],
                "Id": 1,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 7,
                "name": "RAM",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 1,
                "values": [
                    {
                        "name": "2 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 3,
                        "CustomProperties": {}
                    },
                    {
                        "name": "4GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال748/60",
                        "price_adjustment_value": 748.6,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 4,
                        "CustomProperties": {}
                    },
                    {
                        "name": "8GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 5,
                        "CustomProperties": {}
                    }
                ],
                "Id": 2,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 4,
                "name": "HDD",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "320 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": null,
                        "price_adjustment_value": 0,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 6,
                        "CustomProperties": {}
                    },
                    {
                        "name": "400 GB",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال3,743/00",
                        "price_adjustment_value": 3743,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 7,
                        "CustomProperties": {}
                    }
                ],
                "Id": 3,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 5,
                "name": "OS",
                "description": null,
                "text_prompt": null,
                "is_required": true,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 2,
                "values": [
                    {
                        "name": "Vista Home",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 8,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Vista Premium",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال2,245/80",
                        "price_adjustment_value": 2245.8,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 9,
                        "CustomProperties": {}
                    }
                ],
                "Id": 4,
                "CustomProperties": {}
            },
            {
                "product_id": 1,
                "product_attribute_id": 9,
                "name": "Software",
                "description": null,
                "text_prompt": null,
                "is_required": false,
                "default_value": null,
                "selected_day": null,
                "selected_month": null,
                "selected_year": null,
                "has_condition": false,
                "allowed_file_extensions": [],
                "attribute_control_type": 3,
                "values": [
                    {
                        "name": "Microsoft Office",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال1,871/50",
                        "price_adjustment_value": 1871.5,
                        "is_pre_selected": true,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 10,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Acrobat Reader",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال374/30",
                        "price_adjustment_value": 374.3,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 11,
                        "CustomProperties": {}
                    },
                    {
                        "name": "Total Commander",
                        "color_squares_rgb": null,
                        "image_squares_picture_model": {
                            "id": 0,
                            "image_base64": null,
                            "image_url": null,
                            "thumb_image_url": null,
                            "seo_filename": null,
                            "mime_type": null,
                            "full_size_image_url": null,
                            "title": null,
                            "alternate_text": null
                        },
                        "price_adjustment": "+ريال187/15",
                        "price_adjustment_value": 187.15,
                        "is_pre_selected": false,
                        "picture_id": 0,
                        "customer_enters_qty": false,
                        "quantity": 0,
                        "Id": 12,
                        "CustomProperties": {}
                    }
                ],
                "Id": 5,
                "CustomProperties": {}
            }
        ],
        "product_specifications": [],
        "product_manufacturers": [],
        "product_review_overview": {
            "ProductId": 1,
            "RatingSum": 0,
            "TotalReviews": 0,
            "AllowCustomerReviews": true,
            "CustomProperties": {}
        },
        "tier_prices": [],
        "associated_products": [],
        "display_discontinued_message": false,
        "current_store_name": "Your store name",
        "Id": 1,
        "CustomProperties": {}
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

  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, product search model is null",
    "model": null
  }
  ` 
  ----
* **URL**
/product/getProductPicturesUrlByProductId

* **Method:**
    `GET`
*  **URL Params**<br/>
    productId=[integer]
    product id<br/>
*   **Required:**<br/>
    productId=[integer]
    product id<br/>
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
          "id": 1,
          "picture_id": 20,
          "product_id": 1,
          "picture_base64": null,
          "picture_url": "http://localhost/content/images/thumbs/0000020_build-your-own-computer.jpeg",
          "seo_filename": "build-your-own-computer",
          "title_attribute": null,
          "alt_attribute": null,
          "mime_type": "image/jpeg",
          "display_order": 0
      },
      {
          "id": 2,
          "picture_id": 21,
          "product_id": 1,
          "picture_base64": null,
          "picture_url": "http://localhost/content/images/thumbs/0000021_build-your-own-computer.jpeg",
          "seo_filename": "build-your-own-computer",
          "title_attribute": null,
          "alt_attribute": null,
          "mime_type": "image/jpeg",
          "display_order": 0
      }
  ]
}
```

* **Error Response:**

* **Code:** 404 NOT FOUND <br />
**Content:** `
{
  "status": 404,
  "message": "Bad request, product id should not be zero",
  "model": null
}
 `
----
  
* **URL**
/product/getProductPictureUrlById

* **Method:**
    `GET`
*  **URL Params**<br/>
    productPictureId=[integer]
    product picture id<br/>
*   **Required:**<br/>
    productPictureId=[integer]
    product picture id<br/>
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
        "id": 20,
        "picture_id": 39,
        "product_id": 16,
        "picture_base64": null,
        "picture_url": "http://localhost/content/images/thumbs/0000039_leica-t-mirrorless-digital-camera.jpeg",
        "seo_filename": "leica-t-mirrorless-digital-camera",
        "title_attribute": null,
        "alt_attribute": null,
        "mime_type": "image/jpeg",
        "display_order": 0
    }
}
```

* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, product picture id should not be zero",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, product picture is not found",
    "model": null
  }
  `
----
  
* **URL**
/product/lastProducts

* **Method:**
    `GET`
*  **URL Params**<br/>
    count=[integer]
    count<br/>
    storeId=[integer]
    store id<br/>
*   **Required:**<br/>
    count=[integer]
    count<br/>
    storeId=[integer]
    store id<br/>
* **Data Params**
    `NONE`

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```
product response data
```

* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, product picture is not found",
    "model": null
  }
  `
  ----
  
* **URL**
/product/bestSellingProducts

* **Method:**
    `GET`
*  **URL Params**<br/>
    storeId=[integer]
    store id<br/>
*   **Required:**<br/>
    storeId=[integer]
    store id<br/>
* **Data Params**
    `NONE`

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```
product response data
```

* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, product picture is not found",
    "model": null
  }
  `
**ShopingCart**
----
  
* **URL**
/shoppingCart/getShoppingCartByCurrentCustomer

* **Method:**
    `GET`
*  **URL Params**<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
*   **Required:**<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
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
        "OnePageCheckoutEnabled": true,
        "ShowSku": false,
        "ShowProductImages": false,
        "IsEditable": false,
        "Items": [],
        "CheckoutAttributeInfo": null,
        "CheckoutAttributes": [],
        "Warnings": [],
        "MinOrderSubtotalWarning": null,
        "DisplayTaxShippingInfo": false,
        "TermsOfServiceOnShoppingCartPage": false,
        "TermsOfServiceOnOrderConfirmPage": false,
        "EstimateShipping": {
            "Enabled": false,
            "CountryId": null,
            "StateProvinceId": null,
            "ZipPostalCode": null,
            "AvailableCountries": [],
            "AvailableStates": [],
            "CustomProperties": {}
        },
        "DiscountBox": {
            "AppliedDiscountsWithCodes": [],
            "Display": false,
            "Messages": [],
            "IsApplied": false,
            "CustomProperties": {}
        },
        "GiftCardBox": {
            "Display": false,
            "Message": null,
            "IsApplied": false,
            "CustomProperties": {}
        },
        "OrderReviewData": {
            "Display": false,
            "BillingAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "IsShippable": false,
            "ShippingAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "SelectedPickUpInStore": false,
            "PickupAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "ShippingMethod": null,
            "PaymentMethod": null,
            "CustomValues": {},
            "CustomProperties": {}
        },
        "ButtonPaymentMethodActionNames": [],
        "ButtonPaymentMethodControllerNames": [],
        "ButtonPaymentMethodRouteValues": [],
        "HideCheckoutButton": false,
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
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, working language is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad reuqest, current currency is not found",
    "model": null
  }
  `
* **URL**
/shoppingCart/getShoppingCartByCurrentCustomerStoreId

* **Method:**
    `GET`
*  **URL Params**<br/>
    storeId=[integer]
    store id<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
*   **Required:**<br/>
    storeId=[integer]
    store id<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
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
        "OnePageCheckoutEnabled": true,
        "ShowSku": false,
        "ShowProductImages": false,
        "IsEditable": false,
        "Items": [],
        "CheckoutAttributeInfo": null,
        "CheckoutAttributes": [],
        "Warnings": [],
        "MinOrderSubtotalWarning": null,
        "DisplayTaxShippingInfo": false,
        "TermsOfServiceOnShoppingCartPage": false,
        "TermsOfServiceOnOrderConfirmPage": false,
        "EstimateShipping": {
            "Enabled": false,
            "CountryId": null,
            "StateProvinceId": null,
            "ZipPostalCode": null,
            "AvailableCountries": [],
            "AvailableStates": [],
            "CustomProperties": {}
        },
        "DiscountBox": {
            "AppliedDiscountsWithCodes": [],
            "Display": false,
            "Messages": [],
            "IsApplied": false,
            "CustomProperties": {}
        },
        "GiftCardBox": {
            "Display": false,
            "Message": null,
            "IsApplied": false,
            "CustomProperties": {}
        },
        "OrderReviewData": {
            "Display": false,
            "BillingAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "IsShippable": false,
            "ShippingAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "SelectedPickUpInStore": false,
            "PickupAddress": {
                "id": 0,
                "first_name": null,
                "last_name": null,
                "email": null,
                "company_enabled": false,
                "company_required": false,
                "company": null,
                "country_enabled": false,
                "country_id": null,
                "country_name": null,
                "state_province_enabled": false,
                "state_province_id": null,
                "state_province_name": null,
                "city_enabled": false,
                "city_required": false,
                "city": null,
                "street_address_enabled": false,
                "street_address_required": false,
                "address1": null,
                "street_address2_enabled": false,
                "street_address2_required": false,
                "address2": null,
                "zip_postal_code_enabled": false,
                "zip_postal_code_required": false,
                "zip_postal_code": null,
                "phone_enabled": false,
                "phone_required": false,
                "phone_number": null,
                "fax_enabled": false,
                "fax_required": false,
                "fax_number": null,
                "formatted_custom_address_attributes": null,
                "custom_address_attributes": []
            },
            "ShippingMethod": null,
            "PaymentMethod": null,
            "CustomValues": {},
            "CustomProperties": {}
        },
        "ButtonPaymentMethodActionNames": [],
        "ButtonPaymentMethodControllerNames": [],
        "ButtonPaymentMethodRouteValues": [],
        "HideCheckoutButton": false,
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
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, working language is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad reuqest, current currency is not found",
    "model": null
  }
  `
    ----
  
* **URL**
/shoppingCart/addToCartByCurrentCustomer

* **Method:**
    `POST`
*  **URL Params**<br/>
    `NONE`
*   **Required:**<br/>
    `NONE`
* **Data Params**
    store_id=[integer]
    store id<br/>
    product_id=[integer]
    product id<br/>
    attributes_xml=[string]
    attributes xml<br/>
    customer_entered_price=[decimal]
    customer entered price<br/>
    quantity=[integer]
    quantity<br/>

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```

```

* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad found, shopping cart item model should not be null",
    "model": null
  }
  `
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
  
  OR
  
    * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Bad found, product is not found",
    "model": null
  }
  `
      ----
  
* **URL**
/shoppingCart/updateShoppingCartByCurrentCustomer

* **Method:**
    `POST`
*  **URL Params**<br/>
    `NONE`
*   **Required:**<br/>
    `NONE`
* **Data Params**
    id=[integer]
    id<br/>
    attributes_xml=[string]
    attributes xml<br/>
    customer_entered_price=[decimal]
    customer entered price<br/>
    quantity=[integer]
    quantity<br/>

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```

```

* **Error Response:**

  * **Code:** 400 BAD REQUEST <br />
  **Content:** `
  {
    "status": 400,
    "message": "Bad request, shopping cart item model should not be null",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
  * **URL**
/shoppingCart/getWishlistByCurrentCustomer

* **Method:**
    `POST`
*  **URL Params**<br/>
    workingCurrencyId=[decimal]
    working currency id<br/>
    workingLanguageId=[decimal]
    working language id<br/>
*   **Required:**<br/>
    workingCurrencyId=[decimal]
    working currency id<br/>
    workingLanguageId=[decimal]
    working language id<br/>
* **Data Params**
    `NONE`

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```

```

* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 400,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, working language is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, current currency is not found",
    "model": null
  }
  `
    * **URL**
/shoppingCart/getWishListByCurrentCustomerStoreId

* **Method:**
    `POST`
*  **URL Params**<br/>
    storeId=[integer]
    store id<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
*   **Required:**<br/>
    storeId=[integer]
    store id<br/>
    workingCurrencyId=[integer]
    working currency id<br/>
    workingLanguageId=[integer]
    working language id<br/>
* **Data Params**
    `NONE`

* **Success Response:**

* **Code:** 200 <br/>
  **Content:** 
```

```

* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 400,
    "message": "Not found, customer is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, working language is not found",
    "model": null
  }
  `
  
  OR
  
  * **Code:** 404 NOT FOUND <br />
  **Content:** `
  {
    "status": 404,
    "message": "Not found, current currency is not found",
    "model": null
  }
  `
  
