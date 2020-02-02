# Class 39 : Digital Certificates


## Learning Objectives
1. The student will identify the difference between TLS and SSL
2. A student will create a self signed digital certificate

## Lecture Outline
1. The student will be introduced into the Diffie-Helman Key Exchange


### What is SSL? HTTPS? TLS?
1. HTTPS allows us to communicate securely over an insecure channel (i.e. open Wifi network at an airport...)
2. Communications on HTTPS are secure because they are encrypted. 
3. Communication is encrypted using Symmetric key encryption. 
	- This encryption requires that bot hte sender and receiver have the same key. (The same key is used to both encrypt and decrypt the data)
4. We need a way for the information to be passed through even an insecure channel that it cannot be intercepted, the external party knowing what the secret key is
5. Diffie Hellman Key Exchange solves this issue...

### Diffie Helman Key Exchange
Diffie Hellman allows two parties to crate a shared secret without revealing it, while doing it 'in the open' (this means that even if someone has access to the information that the two parties exchanged, 
they still won't  be able to access the secret key)
- It is all Math

1. Two numbers are picked, they are usually called `p` and `g` p - prime, g- generator
2. A prime number is a natural number, greater than 1, and has no divisors other than 1 and itself. 
3. `g mod p for x` (x is between 1 and p-1).
	- Example: 3^1 mod 7 = 3
	- 3^2 mod 7 = 2
	- 3 ^3 mod 7 = 6
4. g = 3, p =7


### EXAMPLE:
Alice and Bob
1. Alice picks `g` and `p` (g = 3, p = 7) and sends a letter with them to Bob
2. Alice also picks a secret number less than p (she picks 2)

3. Bob receives Alice's `p` and `p` and picks his own secret number less than p (he picks 5)
4. Bob computes his `g^bobsSecret mod p` (3^5 mod 7 = 5). 
5. Bob sends this number to Alice. this is called `NumberBobSent`

6. At the same time Alice computes `g^secretAlice` mod p (3^2 mod 7 = 2)
7. She sends it to bob, we will call this `numberAliceSent`

8. Alice receives Bob's letter with number 5
9. She then computes the `numberBobSent^secretAlice mod p` (5^2 mod 7 = 4)

10. Bob receives Alice’s letter and does the same: `numberAliceSentsecretBob mod p`, in this case 25 mod 7 = 4.
 
11. The shared secret is 4
12. Whoever reads this letter can read `p`, `g`,`numberBobSent`, `numberaliceSent` however, they don't know the shared secret or bob and alice's ind. secret keys
13. This shared secret is used to encrypt and decrypt their communications

14. This works because large primes is costly to figure out with shared secretes with information that an eavesdropper may have access too. 


### Digital Certificates 
1. what if someone sits in between alice and bob, and intercepts the interactions and replaces them with her own. 
2. She establishes her own secret key with both Alice and Bob and neither Alice or Bob know this is happening.
3. Neither Alice or bob know that they are being attacked and think their information is private. 
4. This is called a `man in the middle` attack
5. This is where digital certificates become so important. 

#### Asymmetric Key Encryption
1. Asymmetric keys provide 1 private and 1 public 
2. Both can encrypt and decrypt --> if you encrypt with one, then you can only decrypt with the other
3. the private key is never supposed to be sent, the public key gets freely sent to anyone/everyone
4. ANything Encrypted with the private key, can only be decrypted with the private key, this ensures that if you receive something that your public key can decrypt that only the private key holder could have sent it.

5. A certificate is just a public key bundled together with information about the holder of the private key (the subject is usually teh website domain)
6. The certificate is trustworthy because it is digitally signed by a certificate authority. (i.e. Symantec, and LetsEncrypt)

7. What is a digital signature?
