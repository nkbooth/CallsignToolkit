# The N1CCK Callsign Toolkit
This is a collection of tools for working with amateur radio callsigns. I needed a toolkit, so I made one. It's not perfect, but it's a start.

## Callsign Validation
There are many things about a callsign that we may wish to validate. This toolkit will validate format, but not check for the existence of the callsign in the FCC database.

### Callsign Format
The `IsValidCallsign` function takes a callsign and returns a boolean indicating whether or not the callsign is potentially valid per FCC Part 97 schema.

### Get Callsign From String
The `GetCallsignFromString` function takes a string and returns the first callsign it finds.  If no callsign is found, it returns an empty string.

## GLAARG VE Number Validation
I am a member of the [Greater Los Angeles Amateur Radio Group](http://www.glaarg.org/). As such, I need to validate and search VE numbers for the group. 

### Is Valid GLAARG VE Number
The `IsValidGLAARGVENumber` function takes a string and returns a boolean indicating whether or not the string is in the format of a valid GLAARG VE number.

### Get GLAARG VE Number From String
The `GetGLAARGVENumberFromString` function takes a string and returns the first potential GLAARG VE number it finds.  If no potential GLAARG VE number is found, it returns an empty string.