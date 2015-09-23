
var REMOTE_CLONE_ACTIONS = '.clone-actions';

function Clone(cloneContainer, clonable) {

    this.master = clonable;
    this.container = cloneContainer;
    
    var actions = this.container.find(REMOTE_CLONE_ACTIONS);
    if (!!actions.length) {
        this.master.actions.hide();

        var cancelButton = actions.find('.clone-cancel'),
        submitButton = actions.find('.clone-submit');

        this.addCancelButton(cancelButton);
        this.master.addSubmitButton(submitButton);
    }
}

Clone.prototype.hasHeader = function() {
    
    if (this.header === undefined || this.header === null || this.header.length === 0) {
        return false;
    }

    return true;
}

Clone.prototype.addCancelButton = function (cancelButton) {

    cancelButton.click({ clone: this }, function (e) {

        e.preventDefault();
        var clone = e.data.clone;

        if (clone.hasHeader()) {
            clone.fold();
        } else {
            clone.fold();
            clone.master.removeClone(clone);
        }

        clone.master.showActions();
    });
}

Clone.prototype.addRemoveButton = function(removeButton) {

    removeButton.click({ clone: this }, function(e) {

        e.preventDefault();
        var clone = e.data.clone;

        clone.master.removeHeader(clone.header);
        clone.fold();
        clone.master.removeClone(clone);
    });
}

Clone.prototype.addEditButton = function (editButton) {

    this.editButton = editButton;

    editButton.click({ clone: this }, function (e) {

        e.preventDefault();
        var clone = e.data.clone;

        clone.master.foldAll();

        clone.unfold();
    });
}

Clone.prototype.fold = function() {

    this.container.slideUp();
    this.folded = true;

    this.master.showActions();

    return this;
}

Clone.prototype.unfold = function () {

    this.container.slideDown();
    this.folded = false;

    this.master.hideActions();

    return this;
}

Clone.prototype.createHeader = function() {
    
    this.header = $(this.master.headerTemplate.clone().html());

    var editButton = this.header.find('.edit-link');

    if (editButton.length) {
        editButton.click({ clone: this }, function(e) {

            e.preventDefault();

            clone.master.foldAll();

            Clone.unfold();
        });
    }

    if (this.header !== undefined) {

        this.header.remove();
    }
    
    var self = this;

    this.container.find('select, input').each(function (index, element) {

        var headerField = $(element).data('header-field');

        if (headerField === undefined) {
            return;
        }

        if ($(element).prop('tagName') === "SELECT") {
            var val = $(element).find(':selected').text();
        } else {
            var val = $(element).val();
        }

        if (val === '' || val === null) {
            self.header.find('#' + headerField).hide();
        } else {
            self.header.find('#' + headerField).text(val);
        }
    });

    this.addRemoveButton(self.header.find('.clone-remove'));
    this.addEditButton(self.header.find('.clone-edit'));

    self.header.find('[data-toggle="tooltip"]').tooltip();

    return this.header;
}

Clone.prototype.setId = function (id) {

    var self = this;

    this.container.find('select, input').each(function(index, element) {

        var cl = $(element);
        var name = cl.attr('name');

        if (name.search(self.master.idRegex) >= 0) {
            name = name.replace(self.master.idRegex, self.master.idPattern);
        } else {
            name = self.master.idPattern + name;
        }
        
        name = name.replace('#id#', id);

        cl.attr('name', name);
    });

    return this;
}