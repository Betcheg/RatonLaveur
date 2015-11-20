# RatonLaveur
Distant computer control with binary and sql database - Proof of concept - For security purpose ONLY.

Created in 2014 for academic purpose.

Code might not be optimal.

##How does it work

When compiled create a binary file. Replace variables starting with YOUR_*** to make it work.
When executed it displays a fake Window Error and hide in process.
It then checks your **mysql** database and search for command to execute every 5 seconds.
Launch commands by inserting row named accordingly in your database. 
Exacutable commands are listed below.

##Commands currently usable :
- OuvrirPage() // Open a web page in the distant computer default browser
- EcranBleu() // Create a fake fullscreen error-like BSOD
- Bip() // Make the distant computer bip... Yep that's it

##WARNING

This piece of software should NEVER be used against someone's will.

I AM NOT RESPONSIBLE FOR YOUR OWN ACTIONS.
