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

<p style="text-align: justify">There are some differences between working on a software product and a software project. Even both essentially are the same, the scope of the work could be different. Even that a software product has timelines to be pursued, the focus of the team is always on that product, wich means their effort are always on one or on a couple of related code base. On the other hand working on a software project the effort is transient, what I mean is that when the project is finished and delivered, the effort to find improvements or new solutions for this code base is not necessary anymore. Once the project is delivered this effort is transfered to the customer or to another team accountable to keep the software running properlly.</p>

<p style="text-align: justify">The core objective with this design is define a couple of standards and patterns to achieve a minimal working software that will be the basis to development of the project and with the flexibility to change when needed and extended when it was required after delivered to production.</p>

### Core package

### Logging package

### <i>[Business domain]</i>.Domain packages

### Microservices packages