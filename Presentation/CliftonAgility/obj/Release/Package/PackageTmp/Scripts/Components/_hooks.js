// Hook
// Add extensibility to objects.

'use strict';

var Hook = {
    hooks: [],

    register: function (name, callback) {
        if ('undefined' === typeof (Hook.hooks[name])) {
            // Always begin with array.
            Hook.hooks[name] = [];
        }

        Hook.hooks[name].push(callback);
    },

    call: function (name, args) {
        if (typeof (Hook.hooks[name]) === 'undefined') {
            // No matches.
            return undefined;
        } else {
            for (var i = 0 ; i < Hook.hooks[name].length ; i++) {
                if (Hook.hooks[name][i](args) === false) {
                    return false;
                }
            }

            return true;
        }
    }
};


window.hooks = Hook;
