# Buber Breakfast API

- [Buber Breakfast API](#buber-breakfast-api)
	- [Create Breakfast](#create-breakfast)
		- [Create Breakfast Request](#create-breakfast-request)
		- [Create Breakfast Response](#create-breakfast-response)
	- [Get Breakfast](#get-breakfast)
		- [Get Breakfast Request](#get-breakfast-request)
		- [Get Breakfast Response](#get-breakfast-response)
	- [Update Breakfast](#update-breakfast)
		- [Update Breakfast Request](#update-breakfast-request)
		- [Update Breakfast Response](#update-breakfast-response)
	- [Delete Breakfast](#delete-breakfast)
		- [Delete Breakfast Request](#delete-breakfast-request)
		- [Delete Breakfast Response](#delete-breakfast-response)

## Create Breakfast

### Create Breakfast Request

```js
POST /breakfasts
```

```json
{
    "Name": "Vegan Sunshine",
    "Description": "Vegan everything! Join us for a healthy breakfast...",
    "startDateTime": "2023-02-23T08:00:00",
    "EndDateTime": "2023-02-23T11:00:00",
    "Savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Breakfast Response

```js
201 Created
```

```yml
Location {{host}}/Breakfasts/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000"
    "Name": "Vegan Sunshine",
    "Description": "Vegan everything! Join us for a healthy breakfast...",
    "startDateTime": "2023-02-23T08:00:00",
    "EndDateTime": "2023-02-23T11:00:00",
    "lastModifiedDateTime": "2023-02-22T11:00:00"
    "Savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```


## Get Breakfast

### Get Breakfast Request

```js
GET /breakfasts/{{id}}
```

### Get Breakfast Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000"
    "Name": "Vegan Sunshine",
    "Description": "Vegan everything! Join us for a healthy breakfast...",
    "startDateTime": "2023-02-23T08:00:00",
    "EndDateTime": "2023-02-23T11:00:00",
    "lastModifiedDateTime": "2023-02-22T11:00:00"
    "Savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```


## Update Breakfast

### Update Breakfast Request

```js
PUT /breakfasts/{{id}}
```

```json
{
    "Name": "Vegan Sunshine",
    "Description": "Vegan everything! Join us for a healthy breakfast...",
    "startDateTime": "2023-02-23T08:00:00",
    "EndDateTime": "2023-02-23T11:00:00",
    "Savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Breakfast Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location {{host}}/Breakfasts/{{id}}
```


## Delete Breakfast

### Delete Breakfast Request

```js
DELETE /breakfasts/{{id}}
```

### Delete Breakfast Response

```js
204 No Content
```
