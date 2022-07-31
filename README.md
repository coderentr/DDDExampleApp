# DDD(Domain Driven Design)

### What is DDD(Domain Driven Design) ?

<p>It is a software approach developed to ensure that business conduct rules are applied in a certain order and harmony.</p>

>Ubiquitous Language

It is the joint communication between the software team and the business unit.

*Actions and concepts in the business unit must have a code-side equivalent.*

>Bounded Context-Context Mapping

It is a recommended structure to be used in complex systems.They are structures with separated borders and frames.They should not communicate with each other unless necessary.</br>
Mapping context is the structure that enables Bounded contexts to communicate with each other.


>Entity & Value object

Entities: They are objects with an identity. It is singular. Changing one of its values does not change the identity of that object.</br>
Value object: They are objects without identity. They can replace each other.

>Aggregate Root

When more than one related object is in a workflow rule, it is called aggregate.</br>
The base object of these objects is aggregate root

