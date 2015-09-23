
'use strict';

var DEFAULT_CLONEABLE_CONTAINER = '.cloneable-container';
var DEFAULT_CLONEABLE_ACTIONS = '.cloneable-actions';
var DEFAULT_CLONEABLE_SUMMARY = '.cloneable-summary';
var CLONE_HEADER_TEMPLATE = '.clone-header-template';

function RemoteClonable(clonableContainer) {
    
	this.cloneContainer = clonableContainer.find(DEFAULT_CLONEABLE_CONTAINER);
	this.actions = clonableContainer.find(DEFAULT_CLONEABLE_ACTIONS);
	this.summary = clonableContainer.find(DEFAULT_CLONEABLE_SUMMARY);
	this.headerTemplate = clonableContainer.find(CLONE_HEADER_TEMPLATE);


	this.clones = [];
	this.interator = clonableContainer.data('iterator');
	this.remoteAction = clonableContainer.data('remote-action');
	this.idRegex = new RegExp(clonableContainer.data('id-regex'));
	this.idPattern = clonableContainer.data('id-template');

	this.parseCurrentClones();
	this.SetupActions();

    this.addClone();
}

RemoteClonable.prototype.SetupActions = function () {

    if (this.actions === undefined) {
        return this;
    }

    var self = this;

    this.actions.find('.clone-add').click(function (e) {

        e.preventDefault();

        self.addClone(true);
    });

    return this;
}

RemoteClonable.prototype.hideActions = function () {

    if (this.actions === undefined) {
        return this;
    }

    this.actions.hide();

    return this;
}

RemoteClonable.prototype.showActions = function () {

    if (this.actions === undefined) {
        return this;
    }

    this.actions.show();

    return this;
}

RemoteClonable.prototype.addSubmitButton = function(submitButton) {
    
    if (submitButton === undefined || submitButton === null || submitButton.length === 0) {
        return;
    }

    var self = this;

    submitButton.click(function (e) {

        e.preventDefault();

        if (!self.cloneContainer.closest('form').valid()) {
            return;
        }

        for (var i = 0 ; i < self.clones.length; i++) {

            var clone = self.clones[i];
            if (!clone.folded) {

                clone.fold();
                self.addHeader(clone.createHeader());
            }
        }

        self.showActions();
    });
}

RemoteClonable.prototype.AppendClone = function(clone, showClone) {

    this.clones.push(clone);

    this.setIds();

    if (showClone) {
        this.ShowClone(clone);
    }
}

RemoteClonable.prototype.ShowClone = function(clone) {
    
    if (clone === undefined) {
        clone = this.clones[this.clones.length - 1];
    }
    clone.container.hide();
    this.cloneContainer.append(clone.container);
    clone.container.slideDown();

    this.hideActions();

    // Configure validation for newly added elements.
    $("form").removeData("validator");
    $("form").removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse("form");
}

RemoteClonable.prototype.FetchClone = function() {

    var self = this;

    $.ajax({
        url: this.remoteAction,
        cache: true,
        success: function(html) {

            var clone = new Clone($(html), self);
            self.AppendClone(clone, true);
        }
    });
}

RemoteClonable.prototype.foldAll = function() {
    
    for (var i = 0 ; i < this.clones.length; i++) {
        this.clones[i].fold();
    }
    return this;
}

RemoteClonable.prototype.addClone = function() {

    this.FetchClone();

    return this;
}

RemoteClonable.prototype.removeClone = function(clone) {

    this.clones.splice(this.clones.indexOf(clone), 1);
    clone.container.remove();
}

RemoteClonable.prototype.removeHeader = function (header) {

    header.slideUp();
    header.remove();

    this.toggleHeaderTitle();
}

RemoteClonable.prototype.addHeader = function (header) {
    header.hide();
    this.summary.append(header);
    header.slideDown();

    this.toggleHeaderTitle();
}

RemoteClonable.prototype.toggleHeaderTitle = function () {

    var headers = this.summary.find('.clone-header');

    if (headers.length > 0) {
        this.summary.find('.header-title').show();
    } else {
        this.summary.find('.header-title').hide();
    }
}

RemoteClonable.prototype.setIds = function () {

    for (var i = 0 ; i < this.clones.length; i++) {
        this.clones[i].setId(i);
    }
    return this;
}

RemoteClonable.prototype.parseCurrentClones = function() {

    var existingClones = this.cloneContainer.find('> .clone');

    for (var i = 0 ; i < existingClones.length; i++) {

        var clone = new Clone($(existingClones[i]), this);

        this.AppendClone(clone, false);

        this.addHeader(clone.createHeader());

        clone.fold();
    }

    return this;
}

$(function () {

    window.clonableContainer = new RemoteClonable($('.cloneable'));
})