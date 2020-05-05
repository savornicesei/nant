Title: NAnt release plan
Order: 10030
---

# NAnt release plan

## v1.1

<table>
    <colgroup>
        <col style="width: 65%; text-align: left" />
        <col style="width: 15%; text-align: center" />
        <col style="width: 10%; text-align: center" />
    </colgroup>
    <thead>
        <tr>
            <th>Description</th>
            <th>Volunteers</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <p>
                    Add additional optional but useful tasks (<code>&lt;sql&gt;</code>, <code>&lt;grep&gt;</code>).
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
    </tbody>
</table>

## v1.0

<table>
    <colgroup>
        <col style="width: 65%; text-align: left" />
        <col style="width: 15%; text-align: center" />
        <col style="width: 10%; text-align: center" />
    </colgroup>
    <thead>
        <tr>
            <th>
                Description</th>
            <th>
                Volunteers</th>
            <th>
                Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <p>
                    Ensure unit tests are available for all core classes.
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Ensure code xml docs are complete and accurate for all non private members.
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Update and add developer docs (code conventions, high level design).
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
    </tbody>
</table>

## v0.9

<table>
    <colgroup>
        <col style="width: 65%; text-align: left" />
        <col style="width: 15%; text-align: center" />
        <col style="width: 10%; text-align: center" />
    </colgroup>
    <thead>
        <tr>
            <th>
                Description</th>
            <th>
                Volunteers</th>
            <th>
                Status</th>
        </tr>
    </thead>
    </tbody>
        <tr>
            <td>
                <p>
                    Move to an <a href="http://www.apache.org/LICENSE">Apache</a> or <a href="http://www.opensource.org/licenses/bsd-license.php">
                        BSD</a>-style license.
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <a href="http://ant.apache.org/manual/CoreTypes/filterchain.html">FilterChain</a>
                    support.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/rogerdahlman/">Roger</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Refactor <code>&lt;solution&gt;</code> task to use <code>&lt;csc&gt;</code> and <code>
                        &lt;vbc&gt;</code> tasks to compile assemblies.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/ianm74/">Ian</a>, <a href="http://sourceforge.net/users/drieseng/">
                    Gert</a>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Validate all static html for XHTML 1.1 compliance as part of the build process.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for <a href="http://nunit.sourceforge.net">NUnit</a> 2.1.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/ianm74/">Ian</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for <a href="http://www.mail-archive.com/nant-developers%40lists.sourceforge.net/msg02785.html">
                        expression evaluator</a> in all places where it makes sense. Support
                    embedded expressions in strings.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/jkowalski/">Jarek</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>&lt;uptodate&gt;</code> task to replace deprecated <code>uptodatefiles</code>
                    and <code>comparefiles</code> attributes of <code>&lt;if&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/jkowalski/">Jarek</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>file::up-to-date</code> function to replace deprecated <code>uptodatefile</code>
                    and <code>comparefile</code> attributes of <code>&lt;if&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for deprecating tasks/types/functions and named attributes.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>85%</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>&lt;ftp&gt;</code> task.
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Get <code>MailTest</code> added to test suite.
                </p>
            </td>
            <td>
            </td>
            <td>pending</td>
        </tr>
    </tbody>
</table>

## v0.8.x

<table>
    <colgroup>
        <col style="width: 65%; text-align: left" />
        <col style="width: 15%; text-align: center" />
        <col style="width: 10%; text-align: center" />
    </colgroup>
    <thead>
        <tr>
            <th>Description</th>
            <th>Volunteers</th>
            <th>Status</th>
        </tr>
    </thead>
    </tbody>
        <tr>
            <td>
                <p>
                    Replace log class and BuildListener/Event support.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for loading loggers/listeners from third party assemblies.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add assembly references support to <code>&lt;resgen&gt;</code> task. For all
                    but .NET 2.0, we need to implement this by copying the resgen tool, and all
                    referenced assemblies to a temp directory, and launch resgen from there.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Use mechanism of <code>&lt;resgen&gt;</code> task for <code>&lt;license&gt;</code>
                    task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for package references to the following tasks:
                </p>
                <ul>
                    <li>
                        <code>&lt;csc&gt;</code>
                    (done)
                    </li>
                    <li>
                        <code>&lt;vbc&gt;</code>
                    (done)
                    </li>
                    <li>
                        <code>&lt;resgen&gt;</code>?</li>
                </ul>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>75%</td>
        </tr>
        <tr>
            <td>
                <p>
                    Added <code>version</code> functions, and remove version functions from <code>assembly</code>
                    namespace.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Depreciate the following built-in properties:
                </p>
                <ul>
                    <li>
                    nant.filename
                    </li>
                    <li>
                    nant.version
                    </li>
                    <li>
                    nant.location
                    </li>
                    <li>
                    nant.project.name
                    </li>
                    <li>
                    nant.project.basedir
                    </li>
                    <li>
                    nant.project.buildfile
                    </li>
                    <li>
                    nant.project.default
                    </li>
                    <li>
                    nant.platform.name
                    </li>
                    <li>
                    nant.platform.win32
                    </li>
                    <li>
                    nant.platform.unix
                    </li>
                    <li>
                    nant.settings.currentframework.description
                    </li>
                    <li>
                    nant.settings.currentframework.frameworkdirectory
                    </li>
                    <li>
                    nant.settings.currentframework.sdkdirectory
                    </li>
                    <li>
                    nant.settings.currentframework.frameworkassemblydirectory
                    </li>
                    <li>
                    nant.settings.currentframework.runtimeengine
                    </li>
                    <li>
                    nant.tasks.*
                    </li>
                </ul>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Support better logging.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Support configuration to enable targeting specific versions of the .NET
                    Framework and additions like the .NET Compact Framework.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/ianm74/">Ian</a>, <a href="http://sourceforge.net/users/drieseng/">
                    Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Think about project event model.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Drop SourceForge from the namespace identifier.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Rename FileSet xml elements: includes =&gt; include, excludes = &gt; exclude,
                    name = &gt; pattern.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add schema generation and validation for tasks.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/skot/">Scott</a></td>
            <td>70%</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add named filesets.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/ianm74/">Ian</a></td>
            <td>70%</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>&lt;cvs&gt;</code> tasks.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drakmar/">Clayton</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Generate docs for build types.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/ianm74/">Ian</a>, <a href="http://sourceforge.net/users/skot/">
                    Scott</a>, <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>85%</td>
        </tr>
        <tr>
            <td>
                <p>
                    Make sure the examples included in the distribution build. Currently some
                    examples fail.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/jawn/">Bernard</a>, <a href="http://sourceforge.net/users/drieseng/">
                    Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for linked resources to the compiler tasks and the <code>&lt;al&gt;</code>
                    task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for multiple filesets to the <code>&lt;zip&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Move <code>&lt;aximp&gt;</code> task from <a href="http://NAntContrib.sourceforge.net">
                        NAntContrib</a> to the <code>NAnt.Win32Tasks</code> assembly, so we can use
                    it in the <code>&lt;solution&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a>
            </td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add support for registering an assembly for <a href="http://www.codeproject.com/dotnet/nettocom.asp">
                        COM interop</a> to the <code>&lt;solution&gt;</code> task. We could
                    delegate this to NAntContrib's <code>&lt;regasm&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/"></a>
            </td>
            <td>pending</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>&lt;choose&gt;</code> task, similar to XSLT's choose pattern.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Add <code>&lt;trycatch&gt;</code> task.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td><a href="http://nantcontrib.sourceforge.net/release/latest/help/tasks/trycatch.html">done</a></td>
        </tr>
        <tr>
            <td>
                <p>
                    Have the <code>&lt;solution&gt;</code> task use <code>TlbImpTask</code> and <code>AxImpTask</code>
                    instead of directly executing the corresponding commandline tools.
                </p>
            </td>
            <td>
                <a href="http://sourceforge.net/users/drieseng/">Gert</a></td>
            <td>done</td>
        </tr>
        <tr>
            <td>
                <p>
                    Modify <code>CompilerBase</code> and <code>AssemblyLinkerTask</code> to pass
                    localized resources to <code>al.exe</code> using the response file instead of
                    passing arguments directly on the commandline.
                </p>
            </td>
            <td></td>
            <td>pending</td>
        </tr>
    </tbody>
</table>