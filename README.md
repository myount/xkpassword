# XkPassword
XkPassword is a C# reimplementation of [Bart Busschots' `xkpasswd.pm`][xkpasswd.pm], a library for generating
secure memorable passwords inspired mainly by [a well-known xkcd comic][xkcd].

This library is provided free of charge, under the same license as `xkpasswd.pm`: see LICENSE.XkPassword for details.

The built-in English wordlist was generated from [SCOWL][scowl], which is made available under an
MIT-style license: see LICENSE.WordList for details.

[xkpasswd.pm]: http://github.com/bbusschots/xkpasswd.pm
[xkcd]: http://xkcd.com/936/
[scowl]: http://wordlist.aspell.net/

## Differences between XkPassword and `xkpasswd.pm`

XkPassword is a reimplementation, not a direct port.  I sought only to duplicate the core functionality of
`xkpasswd.pm`.  Therefore, XkPassword does not have multiple preset configurations as `xkpasswd.pm` does,
though the `XkPasswd` class's constructor does set defaults similar to the "default" configuration of
`xkpasswd.pm`.  It is assumed that the consuming application will provide some capacity for storing and
reusing different configurations.

# XkPassword.Demo

XkPassword.Demo is a rudimentary application which demonstrates all capabilities of XkPassword except the
ability to choose a different word list file.  It is built using Windows Presentation Foundation and requires
version 4.5 of the .NET Framework.