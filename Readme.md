#���̃v���W�F�N�g�ɂ���

Spajam�ł݂�Ȃ��X�}�z�A�v����i�߂Ă����������Ă݂���B

## �Z�p�\��

### �J����

VisualStudio2022�Ή�

### �e�y�[�W�̍쐬

.Net MAUI�̃e���v���[�g�t�@�C�����g���č쐬

### �����쐬���̎Q�l����

https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/

### ���j���[��ʂ̍ŏI�I�ȑJ��(ReleasePlan LastFlow)
```mermaid
flowchart LR
    subgraph App
        subgraph Menu
           userMemoTab -->userMemoDetail
           itemListTab -->itemList
           facilitySearchTab -->facilitySearchDisplay
           medicinedinputFormTab --> medicinedinputForm
        end
    end
User --> App --> Display
```