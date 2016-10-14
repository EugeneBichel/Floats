Based on pluralsight course: Math for Programmers

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
		- The only fractions that can be are fractions of the form something/(2 into n)
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
	
## Scientific Notation (Exponential notation)

1.57*(10 into 13)

In principle, this is how a computer stored floating point numbers (but in binary)

1.57 is mantissa (significand)
10 is base
13 is exponent

Number = mantissa * (base into exponent)
Negative number = -mantissa * (base into exponent)

Ex.:

3 = 3.00 * (10 into 0)
30 = 3.00 * (10 into 1)
0.03 = 3.00 * (10 into -2)
 
### Takes very little space in the computer
1.57 * (10 into 13)

You need to save:
- sign +
- mantissa 1.57
- exponent 13

So write it like this:
1.57E+13

## Base 2 Scientific Notation (IEEE754)

number = mantissa * (2 into exponent)
negative number = -mantissa * (2 into exponent)

Ex.:
1 = 1.00*(2 into 0)
2 = 1.00 * (2 into 1)
3 = 1.50 * (2 into 1)

### 32-bit Floating Points

32 bit:

- the first from left bit is Sign Bit
- the next 8 bits are exponent
- the last 23 bits are mantissa

#### Sign Bit

0 8bits 23bits  = positive number
1 8bits 23bits = negative number

#### Exponent Bits

8bits of exponent represents unsigned integer

### 64-bit Floating Points
sign - 1bit
exponent - 11bits
mantissa - 52bits


## Zero

if exponent and mantissa are 0 then it is 0


## Infinity

### What is 1/0
- for integers: exception
- mathematically: infinity
- for floating points: infinity

### What is 0/0
- mathematically: it is undefined: the answer cound be anything
- for floating points: answer is Not-a-Number (NaN)

NaN = [any sing][FF][mantissa not all zeros] 

- NaN + anything = NaN
- NaN * anything = NaN
- 4 + infinity = infinity
- anything / infinity = 0

### What infinity / infinity

infinity / infinity = NaN


## Equality

### Integers: equality is reliable because integers are exact

### Floating points: not so clear-cut

float f1 = 1.1f;
float f2 = 1.05f + 0.05f;

f1 != f2;

What happeded?
float f1 = an approximation to 1.1f;
float f2 = an approximation to 1.5f +
			an approximation to 0.05;
			
Important! Beware of comparing floating-points for equality
The result might not be what you expect.

Consider the following example:
float f3 = 1.1f;
float f4 = f3;

if(f3 == f4) //true


On the other hand:
double d1 = 1.1;
double d2 = (double)(float)d1;
if(d1 == d2) //false


## Reproducibility

float f3 = 1.05f + 0.05f;

result in computer1 can be not equal to result in computer2

## What it means for coding

- Dictionary keys
```c#
var dict = new Dictionary<float, stirng>();
```
Do not use floating point numbers as dictionary keys or hashtable keys

- Equality comparison
```c#
if(f1 == f2)
```
Do not compare floating points for equality

### Alternatives to Floating Point Equality
1. can you use integers?
//double priceDollars;
int priceCents;

2. Can you use comparison?
//if(f1 == f2)
if(f1 >= f2)

3. Can you check for nearness in value?
//if(f1 == f2)
static float epsilon = 1.0e-6f;
if(Math.abs(f1 - f2) < epsilon) {
}

epsilon - usually means a very small quantity


## Decimal Types
Penalty: arithmetic operations are massively slower with decimal
