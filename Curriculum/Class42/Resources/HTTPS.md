# Web Security

## HTTPS

HTTPS is important for 3 main reasons:

1. Privacy
2. Integrity
3. Identification


### Privacy
Privacy means that no unauthorized parties can
interfere with your information that 
is being transmitted.

#### HTTP vs HTTPS
HTTP means that you are not on a secure connection. 

When you navigate to a site that is not enforcing HTTPS
that means that your information you are inputting
may not be private. Be careful when you are 
inputting information. such as personal information
into a site that is not protected by HTTPS.



### Integrity

Integrity means that the state of the information that you are
working with does not change state and is not changed
by any unauthorized users in the process of transmission. 

Examples of integrity and security:
Man in the middle attacks.


### Identification

Identification is the ability to know who exactly is sending the information.
This is most commonly done through digital certificates that can identify the sender
of the data

Digital Certificates:
SSL Certificates allow us the ability to ensure that we are connected 
exactly with the receiver you are expecting. We know that we can "trust" 
this certificate or site by the certificate authority that authorizes 
digital certificate. 


### Encryption

1. What is encryption?
- Encryption is the act of using some sort of algorithm to "scramble" or 
change the data so that it is unreadable by others. 

2. What is decryption
- Decryption is reversing the algorithm used to encrypt to figure out the message.

When you encrypt, you need to know more than just the algorithm...you also need the key.
without the key, you still wont be able to figure out the decryption. 

#### Symmetric Key Algorithm
Symmetric Key algorithm is when there is only one key to encrypt and decrypt a message.

Here is the data flow:
1. Before sending a message, the message is encrypted with a key
2. The only person who has a copy of the key can decrypt and read the message.
3. This key needs to be kept private, you should not share this key. **Anyone who has this key can decrypt the message**

Symmetric key algorithms are not easy to share. The distribution of the key can be tricky. 

You gotta be "sneaky"

#### Asymmetric Key Algorithm
In an asymmetric key algorithm...you have 2 keys. 
1. One key is public
2. One key is private.

Both keys are paired to work together

With Asymmetric key algorithm...you can share your public key with anyone as plain text. 
It doesn't matter who has the public key, because only the holder of the private key can 
decrypt the message and read it. 

Workflow:
1. A Message is encrypted with the public key
2. Sent to the Owner of the public key (who should also have the private key)
3. The message is decrypted with the private key
4. Message is readable. 

Advantages of Asymmetric Keys:
1. Privacy - No one else can read the data
2. Identification - only the holder of the private key decrypt and read it. Only the 
owner of the 2 keys can open the message. 

#### The 3 way handshake

1. Client says Hello
	- Client sends a list of SSL/TLS versions
	and encryption algorithms that the client can use

2. Server Says Hello
	- The server looks at the accepted list of ssl versions and picks the "best" one.
	- replies with certificate (includes public key) 

3. A Secure Connection is established
	- Client confirms the Server is who they say they are
	- Client encrypts a key with the server's public key
	- sends the message back to hte server

3a. The server uses the private key to decrypt key "premaster key"
	- Now they have a "shared secret"

The server than sends a test message to client to confirm
that it they are both sharing the same secret to prove a secure connection.

## HTTP
HyperText Transfer Protocol

protocol used by the web servers to communicate and exchange information

the "s" in HTTPS stands for "secure"

you create an HTTPS connection by sending data with SSL/TLS

## SSL
SSL stands for "Secure Socket Layer"

(protocol created by netscape)

SSL was first created by NETscape in 1995.
The first version was not released, the second version had some major issues

in 1999 new standards were needing to be added since more 
browsers were becoming more popular. 

Eventually the IETF (Internet Engineering Task Force) became the 
to handle the standards of internet protocols. 

In 1999 the IETF released TLS Version 1.0 (SSL 3.1)

## TLS,
SSL renamed. TLS stands for "Transport Layer Security"

TIMELINE:

2006: TLS1.1 was released

2008: TLS 1.2 was released (had some flaws and exploits)

2013: Browsers didn't start to support TLS 1.2 until 2013

2015: (May) SSL 3.0 was deprecated.

2018: TLS 1.3 was approved.

### TLS 1.3
TLS 1.2 is still recommended but TLS 1.3
brings some good security improvements. 


### Summary

1. HTTP is just a HTTP protocol but with data encryption
using SSL/TLS
2. The "s" in HTTPS is "secure".
3. SSL was the original and now deprecated protocol created by netscape in the 90s.
3. TLS is the new protocol for security encryption on the web
4. The web is maintained by the IETF


## Cert Authorities

A certificate authority (CA) is a 3rd party organization with 3 main objectives:
1. Issue Certificates
2. Confirm the identities of the Cert owners
3. Provide proof that a cert is valid. 

### Examples:
1. Let's Encrypt
2. Verisign
3. Comodo
4. GoDaddy
5. DigiCert
6. Symantec


Its hard to be a CA. 
You need to be trusted to be accepted in a root store

Companies like Windows, Mozilla, and Apple all run their own root store
that they pre-install in the computer or device. 

Three different types of certificates:
1. Domain Validated
	- the certificate just verifies the domain name (nothing else), bare min of what you need
2. Organization Validated
	- the cert requires the valid and manual verification of the org behind the cert
3. Extended Validation
	- the cert requires an exhaustive verification of the business. 

This results in the browser displaying a cert badge

## Cert Validation Process:
1. When a CA issues a cert, they sign the cert with a root cert pre-installed in the root store
2. This is usually an "intermediate" cert signed with a root cert
3. The intermediate cert is easier to revoke since it is not located on the device directly. 

### STeps
1. Browser connects to site via HTTPS and downloads the cert
2. The cert is not a root cert
3. The browser downloads the cert that was used to sign the cert on the site
4. Still not a root cert
5. The browser once more looks at the cert that signed the intermediate cert
6. Its a root cert!
The entire cert chain is then trusted and the site cert is trusted as well

In the event that the last certificate is not a root certificate and there are no more certs to download, the chain is untrustworthy. 

## Self- Signed Certs
A self signed cert is a certificate that you cna create yourself!

it can provide the same level of encryption as one generated by an authority

Most browsers checks that the cert is from a trusted authority. Visitors are then warned that the cert is not trusted. 

Self signed certs can be useful for testing and intranets but don't use them on public site

The biggest difference between a self-signed and a trusted CA is that a trusted 
CA has more to 'prove". its a certificate that can be verified. 
