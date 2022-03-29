# TD6

## Content

This solution contains three projects:
  - `MathsLibrarySoap`,
  - `MathsLibraryRest`,
  - `Soap Client`.

`MathsLibrarySoap` is a SOAP server exposing a SOAP server allowing one to
perform basic arythmetic operations using the SOAP protocol. Similarly,
`MathsLibraryRest` aims to provide the same functionnalities using a REST
interface instead.

`Soap Client` is just a super simple client which issues a SOAP request to the
corresponding server.


## Interfaces

The two servers implement the following four methods:

| Method name | What it does                              | Input (type)             | Output (type) |
| ----------- | ----------------------------------------- | ------------------------ | ------------- |
| `Add`       | Performs the addition of two values       | a (integer), b (integer) | a + b (int)   |
| `Sub`       | Performs the subtraction of two values    | a (integer), b (integer) | a - b (int)   |
| `Mul`       | Performs the multiplication of two values | a (integer), b (integer) | a * b (int)   |
| `Div`       | Performs the division of two values       | a (integer), b (integer) | a / b (float) |

The REST endpoint can be used with the following URLs: for instance, issuing an
HTTP GET request to the following URLs will always result in `42` as response:
  - [`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Add?a=41&b=1`],
  - [`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Sub?a=43&b=1`],
  - [`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Mul?a=21&b=2`],
  - [`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Div?a=84&b=2`].


## Launching the projects

When all the projects are launched, a SOAP client terminal window is opened. It
displays `42`, which is the result of `41 + 1`. The SOAP and REST servers are
started in background.

[`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Add?a=41&b=1`]: http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Add?a=41&b=1
[`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Sub?a=43&b=1`]: http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Sub?a=43&b=1
[`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Mul?a=21&b=2`]: http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Mul?a=21&b=2
[`http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Div?a=84&b=2`]: http://localhost:8733/Design_Time_Addresses/MathsLibraryRest/MathOperations/Div?a=84&b=2