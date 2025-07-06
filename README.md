# HuzaifaHassan.SecureStringUtils

[![NuGet version](https://img.shields.io/nuget/v/HuzaifaHassan.SecureStringUtils.svg?style=flat-square)](https://www.nuget.org/packages/HuzaifaHassan.SecureStringUtils/)
[![Build & Test](https://github.com/HuzaifaHassan/SecureStringUtils/actions/workflows/ci.yml/badge.svg)](https://github.com/HuzaifaHassan/SecureStringUtils/actions)

A lightweight, production-ready **C# library** for secure string handling: masking, hashing, and constant-time secure comparison.

---

## ✨ **Features**
- ✅ Mask credit card numbers, emails, and other sensitive strings
- 🔒 Constant-time string comparison to avoid timing attacks
- 🔑 SHA-256 hashing utility
- 📦 Clean, documented, and test-covered NuGet package

---

## 📦 **Installation**
Add via NuGet:
```bash
dotnet add package HuzaifaHassan.SecureStringUtils
## 🚀 Usage
```csharp
using SecureStringUtils.Masking;
using SecureStringUtils.Hashing;
using SecureStringUtils.Comparison;

var maskedCard = "1234567812345678".MaskCreditCard();
var maskedEmail = "huzaifa@example.com".MaskEmail();
var hash = "mypassword".ToSha256Hash();
var isEqual = SecureComparer.SecureEquals("secret1", "secret2");
```

## ✅ License
MIT
*/
