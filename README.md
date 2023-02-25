<h1>[dotnet] Lab Arquitetura - v2</h1>

<h2>Roadmap</h2>
<ul>
    <li>Concise Business Core isolation</li>
    <li>At least a minimal code reusability and standardization</li>
    <li>Define a starting point to solve common problems but it's not a final solution</li>
    <li>to be continued ...</li>
</ul>

<h2>Constraints</h2>
<ul>
    <li>Database agnostic but designed primarilly for adopting Microsoft Entity Framework</li>
    <li>Frontend framework agnostic but designed primarilly for adopting SPA like Angular, Vue and React</li>
    <li>to be continued ...</li>
</ul>
<br />

<h2>The design explained</h2>

<p style="text-align: justify">This design IS NOT a silver bullet but a starting point to help discover the real design as the programming evolves and rules and problems are better understood and new scenarios and/or technical issues come up.</p>

<p style="text-align: justify">Even thought some names could indicate, it is not exactly a DDD implementation as defined by Eric Evans<sup>1</sup>. It is a layered design that adopt known patterns as it was done in DDD, but not intending to name as new solution or marketable name to help saling as something totally new.</p>

<p style="text-align: justify">There are some differences between working on a software product and a software project. Even both essentially are the same, the scope of the work could be different. Even if a software product has timelines to be pursued, the focus of the team is always on that product, wich means their effort are always on one or on a couple of related code base. On the other hand working on a software project the effort is transient, what I mean is that when the project is finished and delivered, the effort to find improvements or new solutions for this code base is not necessary anymore. Once the project is delivered this effort is transfered to the customer or to another team accountable to keep the software running properlly.</p>

<p style="text-align: justify">The core objective with this design is define a couple of standards and patterns to achieve a minimal working software that will be the basis to development of the project and with the flexibility to change when needed and extended when it was required after delivered to production.</p>

<p style="text-align: justify">The following packages could be a good starting point for most of the projects. Let's dive into each one:</b>

<h2>The <i>Core</i></h2>

<h3>The <i>Models</i></h3>
<p>Define the base that will help map to ORM framework and will support common actions like logging changes.</p>

```C#
// This base class already initialize the id
// attribute and define a standard to identify an
// entity when mapping it to an ORM framework
public class BaseModel {
    ...
    public Guid Id {get; set;} = Guid.NewGuid();
    ...
    // Other common attributes could be defined
    // but paying attention to the constraint that
    // this is designed primarilly to work with
    // Entity Framework, to avoid underired mappings
    // you should mark the attributes that will be used
    // as "auxiliary" to handle the models as
    // virtual
    public virtual string CurrentUserId { get; set; }
}
```

<h3>The <i>Types</i></h3>
<p>Some types could be defined globally to avoid code replication that define the same thing across the projects. For example let's suppose we need to store money type in different classes. We have several approaches, but let's compare two of them:</p>

```C#
// This attend the solution, but what to do when currency exchange is required, 
// i.e. an offshore employee is contracted and will receive in the local currency?
class Employee {
    ...
    public decimal CurrentSalary {get; set;}
    ...
}

// The natural decision could be adding Currency attribute
class Employee {
    ...
    public decimal CurrentSalary {get; set;}
    public string Currency {get; set;}
    ...
}

// What if we have a specific type for money?
struct Money {
    ...
    public decimal Amount {get; set;}
    public string Currency {get; set;}
    ...
}

// It could be reused in several models
class Employee {
    ...
    public Money CurrentSalary {get; set;}
    ...
}

class JournalEntry {
    ...
    public Money Debits {get; set;}
    public Money Credits {get; set;}
    ...
}
```

<h2>The <i>Logging</i> package</h2>

<h2>The <i>[Business domain].Domain</i> packages</h2>

<h2>The <b>API/Workers/Microservices</b> packages</h2>