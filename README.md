# The N1CCK Callsign Toolkit
This is a collection of tools for working with amateur radio callsigns. I needed a toolkit, so I made one. The design theory is absolutely guided by the KISS (keep it simple, stupid) method - if there is a choice between "simple" and "fancy", I will choose simple.

## Callsign Validators
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

## Callbook Lookups
Tools to use various callbook lookup services.

### Hamcall.dev
Hamcall is a free (no auth needed) callbook lookup service. It currently  supports only US licenses.
#### GetCallInfo (static)
Accepts callsign as a string; if found, returns a JSON string with the following fields:
- callsign
- name (full name)
- first_name
- mi
- last_name
- class
- address (street address, if available)
- city
- state
- zip
- po_box (integer; if a PO Box address is used, address will be blank.)
- grant
- effective
- expiration
- frn
- file_number
- last_lotw (date of last LOTW upload)
- license_key
- dmr_id [int]

### QRZ XML Lookup
Will return JSON-formatted string of the QRZ XML API callsign data response.  
Requires QRZ_USERNAME and QRZ_PASSWORD environment variables to be set.