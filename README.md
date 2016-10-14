# Floating Points
- They are not merely integers with fractions tacked on
	- They are completely different entities from integers

## Types of Numbers

- Real numbers are all numbers on the line: ... -5 -4 -3 -2 -1 0 1 2 3 4 5 ...
- Fractions: one number divided by another: 2/5
ex.: 2/5 is a sum of 5 equal portions, where sum equals 2
- Rational numbers are numbers that can be represented as fractions
- Irrational numbers are numbers that can not be represented as a fraction

Really, full line of numbers is a set of irrational numbers.

## Understanding Decimals

1.5: 1 means how many 1's and 0.5 means how many 10th's there are.
1.5 = 1*1 + 5*(1/10)

## Fractions in Binary

0.1 = 1*(1/2) = 1/2
0.11 = 1*(1/2)+1*(1/4) = 3/4

## Fractions in Hexadecimal
0.1 = 1*(1/16) = 1/16
0.8 = 1*(1/16) = 1/2
0.C = 12*(1/16) = 12/16=3/4

## Fractions
- Most numbers can not be exactly represented. 

Ex.: there are infinite number of numbers in [0.5; 0.6] range.
Or even, there are infinite number of numbers in [0.00000005; 0.00000006] range.

## Representing Numbers

- Important! Most of the numbers your computers stores are inaccurate.
- You have to approximate.
- Even some simple fractions must be approximated.
Ex.: 1/3 = 0.(3)
that is why you have to store something like:
0.3333
And it is approximated value.
0.333 is very near 1/3, but 0.333 != 1/3

## Exact Fractions
- In Decimal
	- 1/n can be represented exaclty of the only prime factors of n are 2 and 5
	Because 10 = 2*5
	
	- For example, can represent exactly:
	1/20 = 0.05 because 20=2*2*5
	1/50 = 0.02 because 50=2*5*5
	
	1/6 = 0.1(6) because 6 can not be factored using 2's and 5's
	
	- If you can represent 1/n exaclty then you can represent 2/n, 3/n etc. exaclty
	2/20, 3/20, 4/20 etc. can be exaclty represented

- In Binary
	- Even  fewer fractions can be represented
		- The only fractions that can be are fractions of the form something/(2 to n)
		In other words:
		1/2 = 0.1
		1/4 = 0.01
		1/8 = 0.001
		1/16 = 0.0001
		etc.
		As well:
		3/8 = 0.011
		3/4 = 0.11
		etc.
		
	- Exact in decimal, not in binary:
	1/5 = 0.2 = 0.(0011) in binary
	1/5 = 0.2 = 0.(3) in hex
	
	- Can not represent exactly in binary or hex:
	0.7
	0.3
	0.9
	etc.
	
## Irrational Numbers
Irrational numbers can never be represented exactly in any base!	
	
Ex.: Math.Sqrt(2) = 1.41421456...

## The difference between rational and irrational

Rational contains repeating part
Irrational does not contain repeating part


## Sum up
- You can store exactly
	- Integers
	- A very small paroportion of rational numbers
	- Nothing else