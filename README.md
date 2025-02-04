# Encrypt / Decrypt API Documentation

## 🎓 Overview
Welcome to the **Encrypt / Decrypt API** documentation! This API provides encryption and decryption functionalities using the **Caesar cipher** with a fixed key of **5**. It is built with **.NET Web** and deployed to **AWS Elastic Beanstalk**.

This project is part of the **Individuell Examination CI/CD** assignment.

## 📌 API Endpoints

### 🔹 GET /encrypt/{text}
Encrypts the given text using the Caesar cipher (key = 5).
#### Request:
```sh
GET https://your-api.aws-region.amazonaws.com/encrypt/{text}
```
#### Response:
```json
"encrypted_text"
```

### 🔹 GET /decrypt/{text}
Decrypts the given text using the Caesar cipher (key = 5).
#### Request:
```sh
GET https://your-api.aws-region.amazonaws.com/decrypt/{text}
```
#### Response:
```json
"decrypted_text"
```

## 🛠 Encryption & Decryption Details
The Caesar cipher shifts each letter in the input text forward (encryption) or backward (decryption) by 5 positions in the alphabet. Non-alphabet characters remain unchanged.

Example:
- **Plaintext:** `hello`
- **Encrypted:** `mjqqt`
- **Decrypted:** `hello`

## 📜 License
This project is for educational purposes as part of the **Individuell Examination CI/CD** assignment and is not intended for commercial use.

