# Liskov Substitution principle

- The father class should't have properties that are not needed in the subclasses.
When the constructor is called, the propertie not needed will always be 0, null or something related, wrong.
The idea is a "least common factor" father class with nothing more than what must be there yes or yes. 
